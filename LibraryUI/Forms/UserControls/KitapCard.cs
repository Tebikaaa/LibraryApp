using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Forms.SubForms;
using LibraryUI.Forms.SubForms.Book;

namespace LibraryUI.Forms.UserControls
{
    public partial class KitapCard : UserControl
    {
        private Kitap _kitap;
        private readonly Action RefreshAction;

        // Yapıcı metod: Kitap verisini alır
        public KitapCard(Kitap kitap, Action refreshAction)
        {
            InitializeComponent();
            _kitap = kitap;
            RefreshAction = refreshAction; // Listeyi yenileme işlemi
            KitapBilgileriniYukle();
        }

        // Kitap bilgilerini yükle
        private void KitapBilgileriniYukle()
        {
            txtId.Text = _kitap.ID.ToString();
            txtKitapAdi.Text = _kitap.KitapAdi;
            txtYazar.Text = $"{_kitap.Yazar}";
            txtYayinYili.Text = $"{_kitap.YayınYılı}";
            txtKategori.Text = $"{_kitap.Kategori.KategoriAdi}";
            txtStokAdedi.Text = $"{_kitap.StokAdedi}";
        }

        // Detaylar butonuna tıklanınca form aç
        private void btnDetaylar_Click(object sender, EventArgs e)
        {
            FrmBookDetails detayForm = new FrmBookDetails(_kitap); // Detayları aç
            detayForm.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sonuc = MessageBox.Show($"{_kitap.KitapAdi} adlı kitabı silmek istediğinize emin misiniz?",
                                        "Silme Onayı",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
            {
                using (var context = new LibraryContext())
                {
                    var kitap = context.Kitaplar.Find(_kitap.ID); // Kitabı bul
                    if (kitap != null)
                    {
                        context.Kitaplar.Remove(kitap); // Kitabı sil
                        context.SaveChanges(); // Değişiklikleri kaydet
                        RefreshAction.Invoke(); // Listeyi yenile
                        MessageBox.Show("Kitap başarıyla silindi!");
                    }
                    else
                    {
                        MessageBox.Show("Kitap bulunamadı!");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmBookUpdate updateForm = new FrmBookUpdate(_kitap); // Güncelleme formuna kitabı gönder
            updateForm.ShowDialog(); // Modal olarak aç
            RefreshAction.Invoke();
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            FrmBookDetails bookDetails = new FrmBookDetails(_kitap);
            bookDetails.ShowDialog();
        }
    }
}
