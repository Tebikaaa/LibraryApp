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
using LibraryUI.Forms.SubForms.Category;
using LibraryUI.Forms.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryUI.Forms
{
    public partial class FrmCategory : Form
    {
        private readonly LibraryContext _context;

        public FrmCategory()
        {
            InitializeComponent();
            _context = new LibraryContext();
            this.Resize += FrmBook_Resize; // Veritabanı bağlantısı
        }

        private void FrmBook_Resize(object sender, EventArgs e)
        {
            KategorileriListele();
        }

        // Form yüklendiğinde kategorileri listele
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            KategorileriListele();
        }

        // 1. Kategorileri Listele
        private void KategorileriListele(string filter = "")
        {
            try
            {
                flowLayoutPanel2.Controls.Clear(); // Paneli temizle

                var lowerFilter = filter.Trim().ToLower();
                var kategoriler = string.IsNullOrWhiteSpace(filter) ?
                    _context.Kategoriler.ToList() :
                    _context.Kategoriler.Where(k => k.KategoriAdi.ToLower().Contains(lowerFilter)).ToList();

                if (kategoriler.Count == 0)
                {
                    lblSonuc.Text = "Sonuç bulunamadı!";
                    lblSonuc.Visible = true;
                }
                else
                {
                    lblSonuc.Visible = false;
                }

                // FlowLayoutPanel genişlik ayarını hesapla
                foreach (var kategori in kategoriler)
                {
                    // Kategori kartını oluştur
                    var kategoriCard = new KategoriCard(kategori, () => KategorileriListele(filter))
                    {
                        Width = (int)(flowLayoutPanel2.Width * 0.98), // Genişlik
                        Height = 80 // Sabit yükseklik
                    };

                    // Panele ekle
                    flowLayoutPanel2.Controls.Add(kategoriCard);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Arama işlemi
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            KategorileriListele(txtSearch.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmCategoryAdd categoryAdd = new FrmCategoryAdd(() => KategorileriListele(txtSearch.Text));
            categoryAdd.ShowDialog();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            KategorileriListele(txtSearch.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
