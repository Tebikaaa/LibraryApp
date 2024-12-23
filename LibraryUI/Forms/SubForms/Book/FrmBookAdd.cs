using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Basiss;
using Microsoft.EntityFrameworkCore;

namespace LibraryUI.Forms.SubForms.Book
{
    public partial class FrmBookAdd : Form
    {
        private readonly LibraryContext _context;
        public FrmBookAdd(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
            BilgileriHazirla(); // Form açıldığında gerekli bilgileri hazırla
        }

        // 1. Form yüklendiğinde kategorileri ve durumları yükle
        private void BilgileriHazirla()
        {
            try
            {
                // ComboBox stilini serbest yazılabilir yap
                cmbKategori.DropDownStyle = ComboBoxStyle.DropDown;

                // Kategorileri yükle
                KategorileriYukle("");

                // Kitap Durumu Enum
                cmbDurum.DataSource = Enum.GetValues(typeof(KitapDurumu));
                cmbDurum.SelectedIndex = 0; // Varsayılan olarak "Mevcut" seçili gelir.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void KategorileriYukle(string filter)
        {
            var kategoriler = string.IsNullOrWhiteSpace(filter) ?
                _context.Kategoriler.ToList() :
                _context.Kategoriler.Where(k => k.KategoriAdi.Contains(filter)).ToList();

            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "ID";
        }

        // 3. Kitap Ekleme Butonu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Zorunlu alanları kontrol et
                if (string.IsNullOrWhiteSpace(txtKitapAdi.Text) ||
                    string.IsNullOrWhiteSpace(txtYazar.Text) ||
                    string.IsNullOrWhiteSpace(txtISBN.Text))
                {
                    MessageBox.Show("Lütfen tüm zorunlu alanları doldurun!");
                    return;
                }

                // Girilen kategori adını kontrol et
                var kategori = _context.Kategoriler.FirstOrDefault(k => k.KategoriAdi == cmbKategori.Text.Trim());
                if (kategori == null)
                {
                    // Yeni kategori ekle
                    kategori = new Kategori { KategoriAdi = cmbKategori.Text.Trim() };
                    _context.Kategoriler.Add(kategori);
                    _context.SaveChanges(); // Yeni kategoriyi kaydet
                }

                // Yeni kitap oluştur
                var yeniKitap = new Kitap
                {
                    KitapAdi = txtKitapAdi.Text,
                    Yazar = txtYazar.Text,
                    ISBN = txtISBN.Text,
                    YayınYılı = int.TryParse(txtYayinYili.Text, out int yil) ? yil : (int?)null,
                    KategoriID = kategori.ID, // Seçilen veya yeni eklenen kategori ID
                    StokAdedi = (int)nudStokAdedi.Value, // NumericUpDown değerini al
                    Durum = (KitapDurumu)cmbDurum.SelectedItem
                };

                _context.Kitaplar.Add(yeniKitap);
                _context.SaveChanges();

                MessageBox.Show("Kitap başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Formu kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
