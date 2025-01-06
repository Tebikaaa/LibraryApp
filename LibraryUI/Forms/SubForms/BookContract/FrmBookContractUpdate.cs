using System;
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
    public partial class FrmBookContractUpdate : Form
    {
        private readonly LibraryContext _context;
        private readonly OduncIslem _oduncIslem;
        private readonly Action _onUpdate;
        private RaporRepository _raporRepository;

        public FrmBookContractUpdate(OduncIslem oduncIslem, LibraryContext context, Action onUpdate)
        {
            InitializeComponent();
            _context = context;
            _oduncIslem = oduncIslem;
            _onUpdate = onUpdate;
            _raporRepository = new RaporRepository(_context);
            BilgileriYukle();
        }

        private void BilgileriYukle()
        {
            // Ödünç bilgilerini yükle
            txtNumara.Text = _oduncIslem.ID.ToString();
            dtpAlindigiTarih.Value = _oduncIslem.OduncTarihi;
            dtpGeriAlinacakTarih.Value = _oduncIslem.IadeTarihi ?? DateTime.Now;
            cmbOduncAlmaTipi.DataSource = Enum.GetValues(typeof(OduncTipi));
            cmbOduncAlmaTipi.SelectedItem = Enum.Parse(typeof(OduncTipi), _oduncIslem.OduncAlmaTipi);

            // Kalan gün hesapla
            txtKalanGun.Text = (_oduncIslem.IadeTarihi.HasValue
                ? (_oduncIslem.IadeTarihi.Value - DateTime.Now).Days
                : (DateTime.Now - dtpAlindigiTarih.Value).Days).ToString();

            // Durumları yükle
            cmbOduncDurumu.DataSource = Enum.GetValues(typeof(OduncDurumu));
            cmbOduncDurumu.SelectedItem = _oduncIslem.OduncDurumu;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Ödünç işlemini güncelle
                _oduncIslem.IadeTarihi = dtpGeriAlinacakTarih.Value;
                _oduncIslem.OduncAlmaTipi = cmbOduncAlmaTipi.SelectedItem.ToString();
                _oduncIslem.KalanGun = (dtpGeriAlinacakTarih.Value - DateTime.Now).Days;
                _oduncIslem.OduncDurumu = (OduncDurumu)cmbOduncDurumu.SelectedItem;

                // Kitaba ait ilgili seri numarasını bul
                var seriNo = _context.SeriNolar
                    .Include(s => s.Kitap)
                    .FirstOrDefault(s => s.KitapID == _oduncIslem.KitapID && s.Durum == KitapDurumu.OduncAlindi);

                if (seriNo != null)
                {
                    // Duruma göre işlem yap
                    if (_oduncIslem.OduncDurumu == OduncDurumu.TeslimEdildi)
                    {
                        if (seriNo.Durum == KitapDurumu.OduncAlindi)
                        {
                            seriNo.Durum = KitapDurumu.Mevcut;
                            seriNo.Kitap.StokAdedi++;
                        }
                    }
                    else
                    {
                        if(seriNo.Durum == KitapDurumu.Mevcut)
                        {
                            seriNo.Durum = KitapDurumu.OduncAlindi;
                            seriNo.Kitap.StokAdedi--;
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Seri numarası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verileri kaydet
                _context.OduncIslemleri.Update(_oduncIslem);
                _raporRepository.RaporEkle("Ödünç Kitap Güncellendi " + $"{_oduncIslem.Kitap.KitapAdi} ,{seriNo} Seri nolu kitabın ödünç durumu güncellendi.");
                _context.SaveChanges();

                MessageBox.Show("Ödünç işlemi başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _onUpdate?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbOduncDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Duruma göre kalan gün güncelleme
            if (cmbOduncDurumu.SelectedItem is OduncDurumu secilenDurum && secilenDurum == OduncDurumu.TeslimEdildi)
            {
                txtKalanGun.Text = "0";
            }
        }
    }
}
