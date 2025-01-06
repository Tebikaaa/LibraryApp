using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Context;
using LibraryUI.Forms.UserControls;
using LibraryEFCore.Models;

namespace LibraryUI.Forms
{
    public partial class FrmRapor : Form
    {
        private readonly LibraryContext _context;

        public FrmRapor()
        {
            InitializeComponent();
            _context = new LibraryContext();
            this.Resize += FrmRapor_Resize;
            RaporlariListele(); // Veritabanı bağlantısı
        }

        private void FrmRapor_Resize(object sender, EventArgs e)
        {
            RaporlariListele();
        }

        // Form yüklendiğinde raporları listele
        private void FrmRapor_Load(object sender, EventArgs e)
        {
            RaporlariListele();
        }

        // 1. Raporları Listele
        private void RaporlariListele(string filter = "")
        {
            try
            {
                flowLayoutPanel2.Controls.Clear(); // Paneli temizle

                var lowerFilter = filter.Trim().ToLower();
                var raporlar = string.IsNullOrWhiteSpace(filter) ?
                    _context.AppRapors.ToList() :
                    _context.AppRapors.Where(r => r.Description.ToLower().Contains(lowerFilter)).ToList();

                if (raporlar.Count == 0)
                {
                    lblSonuc.Text = "Sonuç bulunamadı!";
                    lblSonuc.Visible = true;
                }
                else
                {
                    lblSonuc.Visible = false;
                }

                // FlowLayoutPanel genişlik ayarını hesapla
                foreach (var rapor in raporlar)
                {
                    // Rapor kartını oluştur
                    var raporCard = new RaporCard(rapor, () => RaporlariListele(filter))
                    {
                        Width = (int)(flowLayoutPanel2.Width * 0.993), // Genişlik
                        Height = 80 // Sabit yükseklik
                    };

                    // Panele ekle
                    flowLayoutPanel2.Controls.Add(raporCard);
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
            RaporlariListele(txtSearch.Text);
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            RaporlariListele(txtSearch.Text);
        }
    }
}
