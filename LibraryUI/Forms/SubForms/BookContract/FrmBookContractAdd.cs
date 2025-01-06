using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Basiss;
using LibraryEFCore.Context;
using LibraryEFCore.DataAccess;
using LibraryEFCore.Models;
using LibraryUI.Basiss;
using Microsoft.EntityFrameworkCore;

namespace LibraryUI.Forms.SubForms.BookContract
{
    public partial class FrmBookContractAdd : Form
    {
        private readonly LibraryContext _context;
        private readonly Action _onAdd;
        private RaporRepository _raporRepository;

        public FrmBookContractAdd(LibraryContext context, Action onAdd)
        {
            InitializeComponent();
            _context = context;
            _onAdd = onAdd;
            _raporRepository = new RaporRepository(_context);
            BilgileriHazirla();
        }

        private void BilgileriHazirla()
        {
            try
            {
                cmbOduncAlmaTipi.DataSource = Enum.GetValues(typeof(OduncTipi));
                cmbOduncAlmaTipi.SelectedIndex = 0;

                dtpAlindigiTarih.Format = DateTimePickerFormat.Custom;
                dtpAlindigiTarih.CustomFormat = "dd MMMM yyyy";

                dtpGeriAlinacakTarih.Format = DateTimePickerFormat.Custom;
                dtpGeriAlinacakTarih.CustomFormat = "dd MMMM yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void UyeBilgileriniGetir()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                TemizleUyeBilgileri();
                return;
            }

            var uyeler = _context.Uyeler
                .Include(u => u.Uyarilar)
                .Where(u => u.Email.Contains(txtEmail.Text.Trim()))
                .ToList();

            if (uyeler.Any())
            {
                cmbAdSoyad.Text = uyeler.First().AdSoyad;

                var secilenUye = uyeler.FirstOrDefault(u => u.Email == txtEmail.Text.Trim());
                if (secilenUye != null)
                {
                    txtUyeNumara.Text = secilenUye.ID.ToString();
                    cmbUyarilar.DataSource = secilenUye.Uyarilar?.Select(u => u.Tipi.ToString()).ToList();
                }
            }
            else
            {
                TemizleUyeBilgileri();
            }
        }

        private void TemizleUyeBilgileri()
        {
            txtUyeNumara.Clear();
            cmbAdSoyad.Text = " ";
            cmbUyarilar.DataSource = null;
        }

        private void KitapBilgileriniGetir()
        {
            if (string.IsNullOrWhiteSpace(txtSeriNo.Text))
            {
                TemizleKitapBilgileri();
                return;
            }

            var seriNo = _context.SeriNolar
                .Include(s => s.Kitap)
                .ThenInclude(k => k.Kategori)
                .FirstOrDefault(s => s.SeriNoKodu == txtSeriNo.Text.Trim());

            if (seriNo != null)
            {
                txtKitapNumara.Text = seriNo.Kitap.ID.ToString();
                txtKitapAdi.Text = seriNo.Kitap.KitapAdi;
                txtYazar.Text = seriNo.Kitap.Yazar;
                txtISBN.Text = seriNo.Kitap.ISBN;
            }
            else
            {
                TemizleKitapBilgileri();
            }
        }

        private void TemizleKitapBilgileri()
        {
            txtKitapNumara.Clear();
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtISBN.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUyeNumara.Text) || string.IsNullOrWhiteSpace(txtKitapNumara.Text))
                {
                    MessageBox.Show("Lütfen tüm zorunlu alanları doldurun!");
                    return;
                }

                var seriNo = _context.SeriNolar.FirstOrDefault(s => s.SeriNoKodu == txtSeriNo.Text.Trim());
                if (seriNo == null || seriNo.Durum != KitapDurumu.Mevcut)
                {
                    MessageBox.Show("Kitap mevcut değil veya ödünç alınmış durumda!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int kalanGun = (dtpGeriAlinacakTarih.Value - dtpAlindigiTarih.Value).Days;
                string oduncTipi = cmbOduncAlmaTipi.Text;

                var uye = _context.Uyeler.FirstOrDefault(u => u.ID == int.Parse(txtUyeNumara.Text));
                var kitap = _context.Kitaplar.FirstOrDefault(k => k.ID == seriNo.KitapID);

                var odunc = new OduncIslem
                {
                    UyeID = int.Parse(txtUyeNumara.Text),
                    Uye = uye,
                    KitapID = seriNo.KitapID,
                    Kitap = kitap,
                    OduncTarihi = dtpAlindigiTarih.Value,
                    IadeTarihi = dtpGeriAlinacakTarih.Value,
                    OduncAlmaTipi = oduncTipi,
                    KalanGun = kalanGun,
                    OduncDurumu = OduncDurumu.TeslimEdilmedi
                };
                seriNo.Durum = KitapDurumu.OduncAlindi;

                _context.OduncIslemleri.Add(odunc);
                _raporRepository.RaporEkle("Ödünç Kitap Eklendi " + $"{uye.AdSoyad}, {kitap.KitapAdi} kitabını ödünç aldı.");
                _context.SaveChanges();
                _onAdd?.Invoke();
                MessageBox.Show("Ödünç işlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUyeEmail_TextChanged(object sender, EventArgs e)
        {
            UyeBilgileriniGetir();
        }

        private void txtSeriNo_TextChanged(object sender, EventArgs e)
        {
            KitapBilgileriniGetir();
        }

        private void dtpGeriAlinacakTarih_ValueChanged(object sender, EventArgs e)
        {
            txtKalanGun.Text = (dtpGeriAlinacakTarih.Value - dtpAlindigiTarih.Value).Days.ToString();
        }

        private void dtpAlindigiTarih_ValueChanged(object sender, EventArgs e)
        {
            txtKalanGun.Text = (dtpGeriAlinacakTarih.Value - dtpAlindigiTarih.Value).Days.ToString();
        }
    }
}
