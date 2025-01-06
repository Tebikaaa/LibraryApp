using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Forms.SubForms.Book;
using LibraryUI.Forms.UserControls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Basiss;
using LibraryUI.Basiss;

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
            BilgileriHazirla(); // Filtre bilgilerini hazırla
        }

        private void FrmBook_Resize(object sender, EventArgs e)
        {
            if (!isResizing)
            {
                isResizing = true;
                Filtrele();
                isResizing = false;
            }
        }

        private void BilgileriHazirla()
        {
            try
            {
                // Kategorileri yükle
                cmbKategori.DisplayMember = "KategoriAdi";
                cmbKategori.ValueMember = "ID";
                cmbKategori.DataSource = _context.Kategoriler.ToList();
                cmbKategori.SelectedIndex = -1;

                // Durumları yükle (Enum)
                cmbDurum.DataSource = Enum.GetValues(typeof(KitapDurumu));
                cmbDurum.SelectedIndex = -1;

                // Stok seçeneklerini yükle
                cmbStok.Items.AddRange(new string[] { "Artan", "Azalan" });
                cmbStok.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bilgileri yüklerken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Filtrele()
        {
            try
            {
                flowLayoutPanel2.Controls.Clear();

                // Filtreleme parametrelerini al
                int? kategoriID = cmbKategori.SelectedValue as int?;
                var durum = cmbDurum.SelectedItem as KitapDurumu?;
                bool stokArtan = cmbStok.SelectedItem?.ToString() == "Artan";
                bool adaGoreAZ = rdbAZ.Checked;
                string aramaMetni = txtSearch.Text.Trim().ToLower();

                // Kitapları yükle
                var kitaplar = _context.Kitaplar.Include(k => k.Kategori).AsQueryable();

                // Kategoriye göre filtre
                if (kategoriID.HasValue)
                {
                    kitaplar = kitaplar.Where(k => k.KategoriID == kategoriID.Value);
                }

                // Duruma göre filtre
                if (durum.HasValue)
                {
                    kitaplar.Where(k => _context.SeriNolar.Any(s => s.KitapID == k.ID && s.Durum.ToString().ToLower() == durum.Value.ToString().ToLower()));
                }

                // Arama metnine göre filtreleme
                if (!string.IsNullOrWhiteSpace(aramaMetni))
                {
                    kitaplar = kitaplar.Where(k => k.KitapAdi.ToLower().Contains(aramaMetni) ||
                                                   k.Yazar.ToLower().Contains(aramaMetni));
                }

                // Stoka göre sıralama
                // Stoka göre sıralama
                var siraliKitaplar = stokArtan
                    ? kitaplar.OrderBy(k => k.StokAdedi)
                    : kitaplar.OrderByDescending(k => k.StokAdedi);

                // Ada göre sıralama
                siraliKitaplar = adaGoreAZ
                    ? siraliKitaplar.ThenBy(k => k.KitapAdi)
                    : siraliKitaplar.ThenByDescending(k => k.KitapAdi);

                // Sonuçları yükle
                var kitapList = siraliKitaplar.ToList();

                if (!kitapList.Any())
                {
                    lblSonuc.Text = "Sonuç bulunamadı!";
                    lblSonuc.Visible = true;
                }
                else
                {
                    lblSonuc.Visible = false;

                    foreach (var kitap in kitapList)
                    {
                        var kitapCard = new KitapCard(kitap, _context, Filtrele)
                        {
                            Width = (int)(flowLayoutPanel2.Width * 0.997),
                            Height = 80
                        };
                        flowLayoutPanel2.Controls.Add(kitapCard);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void cmbStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void rdbAZ_CheckedChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void rdbZA_CheckedChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void btnNewKitap_Click(object sender, EventArgs e)
        {
            FrmBookAdd bookAdd = new FrmBookAdd(_context);
            bookAdd.ShowDialog();
            Filtrele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Filtrele();
        }
        private void KategoriAc_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.ShowDialog();
        }
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cmbKategori.SelectedIndex = -1;
            cmbDurum.SelectedIndex = -1;
            cmbStok.SelectedIndex = -1;
            rdbAZ.Checked = true;
            txtSearch.Clear();
            Filtrele();
        }
    }
}
