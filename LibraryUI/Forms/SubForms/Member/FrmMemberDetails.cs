using System;
using System.Windows.Forms;
using LibraryEFCore.Models;

namespace LibraryUI.Forms.SubForms.Member
{
    public partial class FrmMemberDetails : Form
    {
        private readonly Uye _uye;

        public FrmMemberDetails(Uye uye)
        {
            InitializeComponent();
            _uye = uye;
            LoadDetails();
        }

        private void LoadDetails()
        {
            lblNumara.Text = _uye.ID.ToString();
            lblAdSoyad.Text = _uye.AdSoyad;
            lblTelefon.Text = _uye.Telefon ?? "Bilgi Yok";
            lblEmail.Text = _uye.Email;
            lblDurum.Text = _uye.UyeStatus ? "Aktif" : "Pasif";
            lblKayitTarihi.Text = _uye.UyeCreated.ToString("dd.MM.yyyy");
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
