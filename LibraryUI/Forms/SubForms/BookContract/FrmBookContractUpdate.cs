using System;
using System.Collections.Generic;
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
    public partial class FrmBookContractUpdate : Form
    {
        private readonly LibraryContext _context;
        private readonly OduncIslem _oduncIslem;
        private readonly Action _onUpdate;

        public FrmBookContractUpdate(OduncIslem oduncIslem, LibraryContext context, Action onUpdate)
        {
            InitializeComponent();
            _context = context;
            _oduncIslem = oduncIslem;
            _onUpdate = onUpdate;
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

                // Kitap durumu güncelleme
                var kitap = _context.Kitaplar.FirstOrDefault(k => k.ID == _oduncIslem.KitapID);
                if (kitap != null)
                {
                    if (_oduncIslem.OduncDurumu == OduncDurumu.Tamamlandı) // Iade edildi durumu
                    {
                        kitap.Durum = KitapDurumu.Mevcut;
                        kitap.StokAdedi++;
                    }
                    else
                    {
                        kitap.Durum = KitapDurumu.OduncAlindi;
                    }
                }

                _context.OduncIslemleri.Update(_oduncIslem);
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
            if (cmbOduncDurumu.SelectedItem is OduncDurumu secilenDurum && secilenDurum == OduncDurumu.Tamamlandı)
            {
                txtKalanGun.Text = "0";
            }
        }
    }
}
