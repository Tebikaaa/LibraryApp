using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Basiss;
using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Forms.SubForms.Member;
using LibraryUI.Forms.UserControls;

namespace LibraryUI.Forms
{
    public partial class FrmMember : Form
    {
        private readonly LibraryContext _context;

        public FrmMember()
        {
            InitializeComponent();
            _context = new LibraryContext();
            this.Resize += FrmMember_Resize;
            BilgileriHazirla();
        }

        private void FrmMember_Resize(object sender, EventArgs e)
        {
            UyeleriListele();
        }

        // Form yüklendiğinde üyeleri listele
        private void FrmMember_Load(object sender, EventArgs e)
        {
            UyeleriListele();
        }

        // Filtre bilgilerini hazırla
        private void BilgileriHazirla()
        {
            // Durumları yükle (Enum)
            cmbDurum.DataSource = Enum.GetValues(typeof(UyeDurumu));
            cmbDurum.SelectedIndex = 0;

            // Tarih filtreleri
            cmbTarih.DataSource = Enum.GetValues(typeof(Tarih));
            cmbTarih.SelectedIndex = 0;

            // E-posta sağlayıcılarını yükle
            cmbEmail.DataSource = Enum.GetValues(typeof(Email));
            cmbEmail.SelectedIndex = 0;
        }

        // 1. Üyeleri Listele
        private void UyeleriListele(string filter = "")
        {
            try
            {
                flowLayoutPanel2.Controls.Clear(); // Paneli temizle

                var lowerFilter = filter.Trim().ToLower();
                var uyeler = _context.Uyeler.AsQueryable();

                // Arama metni filtresi
                if (!string.IsNullOrWhiteSpace(filter))
                {
                    uyeler = uyeler.Where(u => u.AdSoyad.ToLower().Contains(lowerFilter));
                }

                // Durum filtresi
                if (cmbDurum.SelectedIndex > 0 && cmbDurum.SelectedItem != null)
                {
                    var seciliDurum = (UyeDurumu)cmbDurum.SelectedItem;
                    if (seciliDurum != UyeDurumu.Hepsi)
                    {
                        uyeler = uyeler.Where(u => u.UyeStatus == (seciliDurum == UyeDurumu.Aktif));
                    }
                }

                // Tarih filtresi
                if (cmbTarih.SelectedIndex > 0 && cmbTarih.SelectedItem != null)
                {
                    DateTime bugun = DateTime.Now;
                    var seciliTarih = (Tarih)cmbTarih.SelectedItem;

                    if (seciliTarih != Tarih.Hepsi)
                    {
                        switch (seciliTarih)
                        {
                            case Tarih.Günlük:
                                uyeler = uyeler.Where(u => u.UyeCreated.Date == bugun.Date);
                                break;
                            case Tarih.Haftalık:
                                DateTime haftaBaslangici = bugun.AddDays(-7);
                                uyeler = uyeler.Where(u => u.UyeCreated >= haftaBaslangici);
                                break;
                            case Tarih.Aylık:
                                DateTime ayBaslangici = new DateTime(bugun.Year, bugun.Month, 1);
                                uyeler = uyeler.Where(u => u.UyeCreated >= ayBaslangici);
                                break;
                            case Tarih.Yıllık:
                                DateTime yilBaslangici = new DateTime(bugun.Year, 1, 1);
                                uyeler = uyeler.Where(u => u.UyeCreated >= yilBaslangici);
                                break;
                        }
                    }
                }

                // E-posta filtresi
                if (cmbEmail.SelectedIndex > 0 && cmbEmail.SelectedItem != null)
                {
                    var seciliEmail = (Email)cmbEmail.SelectedItem;
                    if (seciliEmail != Email.Hepsi)
                    {
                        string emailSonu = seciliEmail.ToString().ToLower();
                        uyeler = uyeler.Where(u => u.Email.ToLower().EndsWith($"@{emailSonu}.com"));
                    }
                }

                // Ad sıralama filtresi
                if (rdbAZ.Checked)
                {
                    uyeler = uyeler.OrderBy(u => u.AdSoyad);
                }
                else if (rdbZA.Checked)
                {
                    uyeler = uyeler.OrderByDescending(u => u.AdSoyad);
                }

                var uyeListesi = uyeler.ToList();

                if (uyeListesi.Count == 0)
                {
                    lblSonuc.Text = "Sonuç bulunamadı!";
                    lblSonuc.Visible = true;
                }
                else
                {
                    lblSonuc.Visible = false;
                }

                // FlowLayoutPanel genişlik ayarını hesapla
                foreach (var uye in uyeListesi)
                {
                    // Üye kartını oluştur
                    var memberCard = new MemberCard(uye, _context, () => UyeleriListele(filter))
                    {
                        Width = (int)(flowLayoutPanel2.Width * 0.997), // Genişlik
                        Height = 80 // Sabit yükseklik
                    };

                    // Panele ekle
                    flowLayoutPanel2.Controls.Add(memberCard);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            UyeleriListele();
        }

        private void cmbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            UyeleriListele();
        }

        private void cmbEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            UyeleriListele();
        }

        private void rdbAZ_CheckedChanged(object sender, EventArgs e)
        {
            UyeleriListele();
        }

        private void rdbZA_CheckedChanged(object sender, EventArgs e)
        {
            UyeleriListele();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UyeleriListele(txtSearch.Text);
        }

        private void btnFiltreTemizle_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbDurum.SelectedIndex = 0;
            cmbTarih.SelectedIndex = 0;
            cmbEmail.SelectedIndex = 0;
            rdbAZ.Checked = true;
            UyeleriListele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            UyeleriListele();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmMemberAdd memberAdd = new FrmMemberAdd(_context, () => UyeleriListele());
            memberAdd.ShowDialog();
        }
    }
}
