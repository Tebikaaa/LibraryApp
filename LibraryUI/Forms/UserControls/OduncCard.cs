using System;
using System.Windows.Forms;
using LibraryEFCore.Context;
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

        public OduncCard(OduncIslem oduncIslem, LibraryContext context, Action listeYenile)
        {
            InitializeComponent();
            _oduncIslem = oduncIslem;
            _context = context;
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
                    var odunc = _context.OduncIslemleri.Include(o => o.Kitap).FirstOrDefault(o => o.ID == _oduncIslem.ID);
                    if (odunc != null)
                    {
                        // Kitap durumunu ve stok bilgisini güncelle
                        var kitap = _context.Kitaplar.FirstOrDefault(k => k.ID == odunc.KitapID);
                        if (kitap != null)
                        {
                            kitap.Durum = KitapDurumu.Mevcut;
                            kitap.StokAdedi++;
                        }

                        _context.OduncIslemleri.Remove(odunc);
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
