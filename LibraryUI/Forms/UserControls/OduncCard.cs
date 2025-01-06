using System;
using System.Windows.Forms;
using LibraryEFCore.Context;
using LibraryEFCore.DataAccess;
using LibraryEFCore.Models;
using LibraryUI.Basiss;
using LibraryUI.Forms.SubForms.BookContract;
using Microsoft.EntityFrameworkCore;

namespace LibraryUI.Forms.UserControls
{
    public partial class OduncCard : UserControl
    {
        private readonly OduncIslem _oduncIslem;
        private readonly LibraryContext _context;
        private readonly Action _listeYenile;
        private RaporRepository _raporRepository;
        public OduncCard(OduncIslem oduncIslem, LibraryContext context, Action listeYenile)
        {
            InitializeComponent();
            _oduncIslem = oduncIslem;
            _context = context;
            _raporRepository = new RaporRepository(_context);
            _listeYenile = listeYenile;

            BilgileriYukle();
        }

        private void BilgileriYukle()
        {
            txtNumara.Text = _oduncIslem.ID.ToString();
            txtKitapAdi.Text = _oduncIslem.Kitap.KitapAdi;
            txtUyeAdi.Text = _oduncIslem.Uye.AdSoyad;
            txtKalanGun.Text = _oduncIslem.KalanGun.ToString();
            txtDurum.Text = _oduncIslem.OduncDurumu.ToString();

            toolTip1.SetToolTip(btnUpdate, "İşlemi Düzenle");
            toolTip1.SetToolTip(btnSil, "İşlemi Sil");
            toolTip1.SetToolTip(btnDetay, "İşlem Bilgisi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmBookContractUpdate bookContractUpdate = new FrmBookContractUpdate(_oduncIslem, _context, _listeYenile);
            bookContractUpdate.ShowDialog();
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            FrmBookContractDetails frmBookContractDetails = new FrmBookContractDetails(_oduncIslem, _context);
            frmBookContractDetails.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"{_oduncIslem.Kitap.KitapAdi} ödünç işlemini silmek istediğinize emin misiniz?",
                                             "Silme Onayı",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ödünç işlemini veritabanından al
                    var odunc = _context.OduncIslemleri
                        .Include(o => o.Kitap)
                        .FirstOrDefault(o => o.ID == _oduncIslem.ID);

                    if (odunc != null)
                    {
                        // İlgili seri numarasını al
                        var seriNo = _context.SeriNolar.FirstOrDefault(s => s.KitapID == odunc.KitapID && s.ID == odunc.Kitap.SeriNolar.First().ID);

                        if (seriNo != null)
                        {
                            // Seri numarasının durumunu güncelle
                            seriNo.Durum = KitapDurumu.Mevcut;

                            // Stok sayısını artır
                            var kitap = _context.Kitaplar.FirstOrDefault(k => k.ID == seriNo.KitapID);
                            if (kitap != null)
                            {
                                kitap.StokAdedi++;
                            }
                        }

                        // Ödünç işlemini kaldır
                        _context.OduncIslemleri.Remove(odunc);
                        _raporRepository.RaporEkle("Ödünç işlemi silindi: " + odunc.Kitap.KitapAdi);
                        _context.SaveChanges();

                        MessageBox.Show("Ödünç işlemi başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _listeYenile?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("Ödünç işlemi bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
