using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Forms.SubForms.Book;
using LibraryUI.Forms.UserControls;
using Microsoft.EntityFrameworkCore;

namespace LibraryUI.Forms
{
    public partial class FrmBook : Form
    {
        private readonly LibraryContext _context;
        private bool isResizing = false;

        public FrmBook()
        {
            InitializeComponent();
            _context = new LibraryContext();
            this.Resize += FrmBook_Resize;
        }

        private void FrmBook_Resize(object sender, EventArgs e)
        {
            if (!isResizing)
            {
                isResizing = true;
                KitaplariListele();
                isResizing = false;
            }
        }

        // Form yüklendiğinde kitapları listele
        private void FrmBook_Load(object sender, EventArgs e)
        {
            KitaplariListele();
        }

        // Kitapları listele ve güncelle
        private void KitaplariListele()
        {
            flowLayoutPanel2.Controls.Clear(); // Paneli temizle

            var kitaplar = _context.Kitaplar.Include(k => k.Kategori).ToList();

            if (kitaplar.Count == 0)
            {
                MessageBox.Show("Henüz kitap eklenmemiş!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // FlowLayoutPanel genişlik ayarını hesapla

            foreach (var kitap in kitaplar)
            {
                // Kitap kartını oluştur
                var kitapCard = new KitapCard(kitap, _context, KitaplariListele)
                {
                    Width = flowLayoutPanel2.Width, // Genişlik
                    Height = 80 // Sabit yükseklik
                };

                // Panele ekle
                flowLayoutPanel2.Controls.Add(kitapCard);
            }
        }

        // Kitaplar yenilendiğinde tekrar yükle
        private void btnYenile_Click(object sender, EventArgs e)
        {
            KitaplariListele();
        }

        private void btnNewKitap_Click(object sender, EventArgs e)
        {
            FrmBookAdd bookAdd = new FrmBookAdd();
            bookAdd.ShowDialog();
            KitaplariListele(); // Yeni kitap eklendiğinde listeyi yenile
        }

        private void btnUpdateKitap_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel2.Controls.Count > 0 && flowLayoutPanel2.Controls[0] is KitapCard kitapCard)
            {
                var kitap = kitapCard._kitap;
                FrmBookUpdate bookUpdate = new FrmBookUpdate(kitap,_context, KitaplariListele);
                bookUpdate.ShowDialog();
            }
        }

        private void flowLayoutPanelKitaplar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
