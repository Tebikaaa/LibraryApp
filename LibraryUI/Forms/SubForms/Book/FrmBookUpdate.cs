using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Basiss;
using Microsoft.EntityFrameworkCore;

namespace LibraryUI.Forms.SubForms.Book
{
    public partial class FrmBookUpdate : Form
    {
        private readonly LibraryContext _context;
        private readonly Kitap _kitap;
        private readonly Action _onUpdate;

        public FrmBookUpdate(Kitap kitap, LibraryContext context, Action onUpdate)
        {
            InitializeComponent();
            _context = context;
            _kitap = kitap;
            _onUpdate = onUpdate;
            BilgileriYukle();
        }

        private void BilgileriYukle()
        {
            txtNumara.Text = _kitap.ID.ToString();
            txtKitapAdi.Text = _kitap.KitapAdi;
            txtYazar.Text = _kitap.Yazar;
            txtISBN.Text = _kitap.ISBN;
            txtYayinYili.Text = _kitap.YayınYılı?.ToString();
            nudStokAdedi.Value = _kitap.StokAdedi;

            // Kategori Listesi Yükle
            var kategoriler = _context.Kategoriler.ToList();
            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "ID";
            cmbKategori.SelectedValue = _kitap.KategoriID;

            // Durum Listesi Yükle
            cmbDurum.DataSource = Enum.GetValues(typeof(KitapDurumu));
            cmbDurum.SelectedItem = _kitap.Durum;

            // Seri Numaralarını Yükle
            var seriNolar = _context.SeriNolar
                .Where(s => s.KitapID == _kitap.ID)
                .Select(s => s.SeriNoKodu)
                .ToList();

            cmbSeriNolar.DataSource = seriNolar; // ListBox veya benzeri bir kontrol eklemelisiniz.
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Güncellenecek kitabı veritabanından çek
                var kitap = _context.Kitaplar.Include(k => k.SeriNolar).FirstOrDefault(k => k.ID == _kitap.ID);

                if (kitap != null)
                {
                    // Kitap Bilgilerini Güncelle
                    kitap.KitapAdi = txtKitapAdi.Text;
                    kitap.Yazar = txtYazar.Text;
                    kitap.ISBN = txtISBN.Text;
                    kitap.YayınYılı = int.TryParse(txtYayinYili.Text, out int yil) ? yil : (int?)null;
                    if(cmbKategori.SelectedValue != null)
                    {
                        kitap.KategoriID = (int)cmbKategori.SelectedValue;
                    }
                    else
                    {
                        MessageBox.Show("Kategori Bulunamadı Seçilmemiş olabilir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    kitap.StokAdedi = (int)nudStokAdedi.Value;
                    kitap.Durum = (KitapDurumu)cmbDurum.SelectedItem;

                    // --- Seri No Güncelleme İşlemleri ---
                    int mevcutStok = kitap.SeriNolar.Count;

                    // Eğer stok artırılırsa yeni seri numaraları ekle
                    if (mevcutStok < kitap.StokAdedi)
                    {
                        for (int i = mevcutStok; i < kitap.StokAdedi; i++)
                        {
                            kitap.SeriNolar.Add(new SeriNo
                            {
                                KitapID = kitap.ID,
                                SeriNoKodu = $"SN-{kitap.ID:D3}-{i + 1:D3}" // Seri no formatı
                            });
                        }
                    }
                    // Eğer stok azaltılırsa fazla seri numaralarını sil
                    else if (mevcutStok > kitap.StokAdedi)
                    {
                        var silinecekSeriNolar = kitap.SeriNolar
                            .OrderByDescending(s => s.ID) // En son eklenenleri sil
                            .Take(mevcutStok - kitap.StokAdedi)
                            .ToList();

                        _context.SeriNolar.RemoveRange(silinecekSeriNolar);
                    }

                    // Veritabanına güncelleme işlemini uygula
                    _context.Kitaplar.Update(kitap);
                    _context.SaveChanges();

                    // Başarı mesajı ve kapanış
                    MessageBox.Show("Kitap başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _onUpdate?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kitap bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbKategori_DropDown(object sender, EventArgs e)
        {
            cmbKategori.DataSource = _context.Kategoriler.ToList();
        }

        private void nudStokAdedi_ValueChanged(object sender, EventArgs e)
        {
            if (nudStokAdedi.Value <= 0)
            {
                cmbDurum.SelectedItem = KitapDurumu.Yok;
            }
        }
    }
}
