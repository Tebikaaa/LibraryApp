using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Context;
using LibraryEFCore.DataAccess;
using LibraryEFCore.Models;
using LibraryUI.Basiss;
using Microsoft.EntityFrameworkCore;

namespace LibraryUI.Forms.SubForms.Book
{
    public partial class FrmBookAdd : Form
    {
        private readonly LibraryContext _context;
        private RaporRepository _raporRepository;
        public FrmBookAdd(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
            _raporRepository = new RaporRepository(_context);
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

                // Aynı isimde kitap kontrolü
                var mevcutKitap = _context.Kitaplar.FirstOrDefault(k => k.ISBN == txtISBN.Text.Trim());
                if (mevcutKitap != null)
                {
                    MessageBox.Show("Bu kitap zaten mevcut. Lütfen farklı bir kitap girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    SeriNolar = new List<SeriNo>() // Seri numaraları ekle
                };

                // Önce kitabı ekle ve ID'sini al
                _context.Kitaplar.Add(yeniKitap);
                _raporRepository.RaporEkle("Kitap Eklendi "+ $"{yeniKitap.KitapAdi} kitabı eklendi.");
                _context.SaveChanges(); // ID burada atanmış olur

                // Seri numaraları ekle
                for (int i = 0; i < yeniKitap.StokAdedi; i++)
                {
                    _context.SeriNolar.Add(new SeriNo
                    {
                        KitapID = yeniKitap.ID, // Artık ID atanmış durumda
                        SeriNoKodu = $"SN-{yeniKitap.ID:D3}-{i + 1:D3}", // Doğru format
                        Durum = KitapDurumu.Mevcut
                    });
                }

                _context.SaveChanges(); // Seri numaralarını kaydet

                MessageBox.Show("Kitap başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Formu kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
