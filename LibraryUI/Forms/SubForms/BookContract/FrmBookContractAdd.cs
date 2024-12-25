using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Basiss;
using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Basiss;
using Microsoft.EntityFrameworkCore;

namespace LibraryUI.Forms.SubForms.BookContract
{
    public partial class FrmBookContractAdd : Form
    {
        private readonly LibraryContext _context;
        private readonly Action _onAdd;

        public FrmBookContractAdd(LibraryContext context, Action onAdd)
        {
            InitializeComponent();
            _context = context;
            _onAdd = onAdd;
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
                cmbAdSoyad.DataSource = uyeler;
                cmbAdSoyad.DisplayMember = "AdSoyad";
                cmbAdSoyad.ValueMember = "ID";

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
            cmbAdSoyad.DataSource = null;
            cmbUyarilar.DataSource = null;
        }

        private void KitapBilgileriniGetir()
        {
            if (string.IsNullOrWhiteSpace(txtSeriNo.Text))
            {
                TemizleKitapBilgileri();
                return;
            }

            var kitap = _context.SeriNolar
                .Include(s => s.Kitap)
                .ThenInclude(k => k.Kategori)
                .FirstOrDefault(s => s.SeriNoKodu == txtSeriNo.Text.Trim())?.Kitap;

            if (kitap != null)
            {
                txtKitapNumara.Text = kitap.ID.ToString();
                txtKitapAdi.Text = kitap.KitapAdi;
                txtYazar.Text = kitap.Yazar;
                txtISBN.Text = kitap.ISBN;
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

                var kitapID = int.Parse(txtKitapNumara.Text);
                var kitap = _context.Kitaplar.FirstOrDefault(k => k.ID == kitapID);
                if (kitap == null || kitap.StokAdedi <= 0)
                {
                    MessageBox.Show("Kitap stokta yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var uyeID = int.Parse(txtUyeNumara.Text);
                var uye = _context.Uyeler.FirstOrDefault(u => u.ID == uyeID);
                if (uye == null)
                {
                    MessageBox.Show("Üye bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int kalanGun = (dtpGeriAlinacakTarih.Value - dtpAlindigiTarih.Value).Days;
                string oduncTipi = (kalanGun <= 7) ? OduncTipi.Günlük.ToString() :
                                   (kalanGun > 7 && kalanGun <= 30) ? OduncTipi.Haftalık.ToString() :
                                   (kalanGun > 30 && kalanGun <= 365) ? OduncTipi.Aylık.ToString() :
                                   OduncTipi.Yıllık.ToString();

                var odunc = new OduncIslem
                {
                    UyeID = uyeID,
                    Uye = uye,
                    KitapID = kitapID,
                    Kitap = kitap,
                    OduncTarihi = dtpAlindigiTarih.Value,
                    IadeTarihi = dtpGeriAlinacakTarih.Value,
                    OduncAlmaTipi = oduncTipi,
                    KalanGun = kalanGun,
                    OduncDurumu = OduncDurumu.Aktif
                };

                kitap.Durum = KitapDurumu.OduncAlindi;
                kitap.StokAdedi--;

                _context.OduncIslemleri.Add(odunc);
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

        private void dtpAlindigiTarih_ValueChanged(object sender, EventArgs e)
        {
            KalanGunHesapla();
        }

        private void dtpGeriAlinacakTarih_ValueChanged(object sender, EventArgs e)
        {
            KalanGunHesapla();
        }
        private void KalanGunHesapla()
        {
            if (dtpGeriAlinacakTarih.Value.Date < dtpAlindigiTarih.Value.Date)
            {
                MessageBox.Show("Geri alınacak tarih, alınan tarihten önce olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpGeriAlinacakTarih.Value = dtpAlindigiTarih.Value;
            }
            txtKalanGun.Text = (dtpGeriAlinacakTarih.Value - dtpAlindigiTarih.Value).Days.ToString();
        }

        private void cmbAdSoyad_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cmbAdSoyad.SelectedItem is Uye secilenUye)
            {
                txtUyeNumara.Text = secilenUye.ID.ToString();
                txtEmail.Text = secilenUye.Email;
                cmbUyarilar.DataSource = secilenUye.Uyarilar?.Select(u => u.Tipi.ToString()).ToList();
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
    }
}
