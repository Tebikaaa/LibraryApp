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

namespace LibraryUI.Forms
{
    public partial class FrmCategory : Form
    {
        private readonly LibraryContext _context;

        public FrmCategory()
        {
            InitializeComponent();
            _context = new LibraryContext();
            this.Resize += FrmBook_Resize;// Veritabanı bağlantısı
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
        private void KategorileriListele()
        {
            try
            {
                flowLayoutPanel2.Controls.Clear(); // Paneli temizle

                var kategoriler = _context.Kategoriler.ToList();

                if (kategoriler.Count == 0)
                {
                    MessageBox.Show("Henüz kategori eklenmemiş!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // FlowLayoutPanel genişlik ayarını hesapla

                foreach (var kategori in kategoriler)
                {
                    // Kategori kartını oluştur
                    var kategoriCard = new KategoriCard(kategori, KategorileriListele)
                    {
                        Width = flowLayoutPanel2.Width, // Genişlik
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmCategoryAdd categoryAdd = new FrmCategoryAdd(KategorileriListele);
            categoryAdd.ShowDialog();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            KategorileriListele();
        }
    }
}
