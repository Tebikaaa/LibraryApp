using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Basiss;

namespace LibraryUI.Forms.SubForms.Book
{
    public partial class FrmBookAdd : Form
    {
        public FrmBookAdd()
        {
            InitializeComponent();
            BilgileriHazirla(); // Form açıldığında gerekli bilgileri hazırla
        }

        // Form yüklendiğinde kategorileri ve durumları yükle
        private void BilgileriHazirla()
        {
            // Kategori Listesi
            using (var context = new LibraryContext())
            {
                cmbKategori.DataSource = context.Kategoriler.ToList();
                cmbKategori.DisplayMember = "KategoriAdi";
                cmbKategori.ValueMember = "ID";
            }

            // Kitap Durumu Enum
            cmbDurum.DataSource = Enum.GetValues(typeof(KitapDurumu));
            cmbDurum.SelectedIndex = 0; // Varsayılan olarak "Mevcut" seçili gelir.
        }

        // Kitap Ekleme Butonu
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

                using (var context = new LibraryContext())
                {
                    // Yeni kitap oluştur
                    var yeniKitap = new Kitap
                    {
                        KitapAdi = txtKitapAdi.Text,
                        Yazar = txtYazar.Text,
                        ISBN = txtISBN.Text,

                        YayınYılı = int.TryParse(txtYayinYili.Text, out int yil) ? yil : (int?)null,
                        KategoriID = (int)cmbKategori.SelectedValue,
                        StokAdedi = (int)nudStokAdedi.Value, // NumericUpDown değerini al
                        Durum = (KitapDurumu)cmbDurum.SelectedItem
                    };
                    yeniKitap.GenerateSeriNo();

                    // Kitabı veritabanına ekle
                    context.Kitaplar.Add(yeniKitap);
                    context.SaveChanges();

                    MessageBox.Show("Kitap başarıyla eklendi!");
                    this.Close(); // Formu kapat
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }
    }
}
