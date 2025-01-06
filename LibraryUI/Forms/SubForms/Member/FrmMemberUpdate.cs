using System;
using System.Windows.Forms;
using LibraryEFCore.Basiss;
using LibraryEFCore.Context;
using LibraryEFCore.DataAccess;
using LibraryEFCore.Models;

namespace LibraryUI.Forms.SubForms.Member
{
    public partial class FrmMemberUpdate : Form
    {
        private readonly LibraryContext _context;
        private readonly Uye _uye;
        private readonly Action _onUpdate;
        private RaporRepository _raporRepository;

        public FrmMemberUpdate(Uye uye, LibraryContext context, Action onUpdate)
        {
            InitializeComponent();
            _context = context;
            _raporRepository = new RaporRepository(context);
            _uye = uye;
            _onUpdate = onUpdate;
            txtNumara.Text = _uye.ID.ToString();
            txtAdSoyad.Text = _uye.AdSoyad;
            txtTelefon.Text = _uye.Telefon;
            txtEmail.Text = _uye.Email;
            cmbDurum.DataSource = Enum.GetValues(typeof(UyeDurumu));
            cmbDurum.SelectedItem = _uye.UyeStatus ? UyeDurumu.Aktif : UyeDurumu.Pasif;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Üye bilgilerini güncelleme
                _uye.AdSoyad = txtAdSoyad.Text;
                _uye.Telefon = txtTelefon.Text;
                _uye.Email = txtEmail.Text;
                _uye.UyeStatus = (UyeDurumu)cmbDurum.SelectedItem == UyeDurumu.Aktif;

                _context.Uyeler.Update(_uye);
                _raporRepository.RaporEkle("Üye güncellendi: " + _uye.AdSoyad);
                _context.SaveChanges();

                MessageBox.Show("Üye başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _onUpdate?.Invoke(); // Güncelleme sonrası action çağır
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMemberUpdate_Load(object sender, EventArgs e)
        {
        }
    }
}
