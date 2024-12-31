using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Basiss;
using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Forms.SubForms.BookContract;
using LibraryUI.Forms.UserControls;
using Microsoft.EntityFrameworkCore;

namespace LibraryUI.Forms
{
    public partial class FrmBookContract : Form
    {
        private readonly LibraryContext _context;
        public FrmBookContract()
        {
            InitializeComponent();
            _context = new LibraryContext();
            this.Resize += FrmBookContract_Resize;
            BilgileriHazirla();
        }
        private void FrmBookContract_Resize(object sender, EventArgs e)
        {
            OduncIslemleriListele();
        }

        private void FrmBookContract_Load(object sender, EventArgs e)
        {
            OduncIslemleriListele();
        }
        private void BilgileriHazirla()
        {
            try
            {
                // Ödünç alma tipi
                cmbTarih.DataSource = Enum.GetValues(typeof(OduncTipi));
                cmbTarih.SelectedIndex = -1;

                // Durum
                cmbDurum.DataSource = Enum.GetValues(typeof(OduncDurumu));
                cmbDurum.SelectedIndex = -1;

                // Varsayılan Sıralama
                rdbAZ.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void OduncIslemleriListele(string filter = "")
        {
            try
            {
                flowLayoutPanel2.Controls.Clear();

                // Filtreleme parametreleri
                var lowerFilter = filter.Trim().ToLower();
                var oduncTipi = cmbTarih.SelectedItem?.ToString();
                var durum = cmbDurum.SelectedItem as OduncDurumu?;
                bool adaGoreAZ = rdbAZ.Checked;

                // Verileri çek
                var oduncIslemleri = _context.OduncIslemleri
                    .Include(o => o.Uye)
                    .Include(o => o.Kitap)
                    .AsQueryable();

                // İsim ve kitap adına göre filtre
                if (!string.IsNullOrWhiteSpace(filter))
                {
                    oduncIslemleri = oduncIslemleri.Where(o =>
                        o.Uye.AdSoyad.ToLower().Contains(lowerFilter) ||
                        o.Kitap.KitapAdi.ToLower().Contains(lowerFilter));
                }

                // Ödünç tipine göre filtre
                if (!string.IsNullOrWhiteSpace(oduncTipi))
                {
                    oduncIslemleri = oduncIslemleri.Where(o => o.OduncAlmaTipi == oduncTipi);
                }

                // Duruma göre filtre
                if (durum.HasValue)
                {
                    oduncIslemleri = oduncIslemleri.Where(o => o.OduncDurumu == durum.Value);
                }

                // Sıralama
                oduncIslemleri = adaGoreAZ
                    ? oduncIslemleri.OrderBy(o => o.Uye.AdSoyad)
                    : oduncIslemleri.OrderByDescending(o => o.Uye.AdSoyad);

                var oduncListesi = oduncIslemleri.ToList();
                if (!oduncListesi.Any())
                {
                    lblSonuc.Text = "Sonuç bulunamadı!";
                    lblSonuc.Visible = true;
                }
                else
                {
                    lblSonuc.Visible = false;
                }

                foreach (var odunc in oduncListesi)
                {
                    var oduncCard = new OduncCard(odunc, _context, () => OduncIslemleriListele(filter))
                    {
                        Width = (int)(flowLayoutPanel2.Width * 0.997),
                        Height = 80
                    };
                    flowLayoutPanel2.Controls.Add(oduncCard);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            OduncIslemleriListele(txtSearch.Text);
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                // Filtreleri sıfırla
                txtSearch.Clear();
                cmbTarih.SelectedIndex = -1; // Ödünç Tipi sıfırla
                cmbDurum.SelectedIndex = -1;    // Durum sıfırla
                rdbAZ.Checked = true;          // Varsayılan sıralama
                OduncIslemleriListele("");     // Listeyi yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmBookContractAdd bookContractAdd = new FrmBookContractAdd(_context, () => OduncIslemleriListele(txtSearch.Text));
            bookContractAdd.ShowDialog();
        }
        private void cmbOduncTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            OduncIslemleriListele(txtSearch.Text);
        }
        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            OduncIslemleriListele(txtSearch.Text);
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            OduncIslemleriListele(txtSearch.Text);
        }
        private void rdbAZ_CheckedChanged(object sender, EventArgs e)
        {
            OduncIslemleriListele(txtSearch.Text);
        }

        private void rdbZA_CheckedChanged(object sender, EventArgs e)
        {
            OduncIslemleriListele(txtSearch.Text);
        }

        private void FrmBookContract_Load_1(object sender, EventArgs e)
        {
        }
    }
}
