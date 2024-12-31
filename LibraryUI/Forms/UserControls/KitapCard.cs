using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Forms.SubForms;
using LibraryUI.Forms.SubForms.Book;

namespace LibraryUI.Forms.UserControls
{
    public partial class KitapCard : UserControl
    {
        public Kitap _kitap { get; private set; }
        public LibraryContext _context { get; private set; }
        private readonly Action RefreshAction;
        private readonly Action ReBuildCardAction;

        // Yapıcı metod: Kitap verisini alır
        public KitapCard(Kitap kitap,LibraryContext context, Action refreshAction)
        {
            InitializeComponent();
            _kitap = kitap;
            _context = context;
            RefreshAction = refreshAction; // Listeyi yenileme işlemi
            KitapBilgileriniYukle();
            ReBuildCardAction = KitapBilgileriniYukle;
        }
        public KitapCard(Kitap kitap, Action refreshAction)
        {
            InitializeComponent();
            _kitap = kitap;
            RefreshAction = refreshAction; // Listeyi yenileme işlemi
            KitapBilgileriniYukle();
            ReBuildCardAction = KitapBilgileriniYukle;
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
            toolTip1.SetToolTip(btnUpdate, "Kitabı Düzenle");
            toolTip1.SetToolTip(btnSil, "Kitabı Sil");
            toolTip1.SetToolTip(btnDetay, "Kitap Bilgisi");
        }

        // Detaylar butonuna tıklanınca form aç
        private void btnDetaylar_Click(object sender, EventArgs e)
        {
            FrmBookDetails detayForm = new FrmBookDetails(_kitap,_context); // Detayları aç
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
            FrmBookUpdate updateForm = new FrmBookUpdate(_kitap,_context,RefreshAction); // Güncelleme formuna kitabı gönder
            updateForm.ShowDialog(); // Modal olarak aç
            RefreshAction.Invoke();
            ReBuildCardAction.Invoke();
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            FrmBookDetails bookDetails = new FrmBookDetails(_kitap,_context);
            bookDetails.ShowDialog();
        }
    }
}
