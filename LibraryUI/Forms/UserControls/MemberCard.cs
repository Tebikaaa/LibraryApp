using System;
using System.Windows.Forms;
using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Forms.SubForms.Member;

namespace LibraryUI.Forms.UserControls
{
    public partial class MemberCard : UserControl
    {
        private readonly Uye _uye; // Seçilen üye
        private readonly Action _listeYenile;
        private readonly LibraryContext _context;

        public MemberCard(Uye uye, LibraryContext context, Action listeYenile)
        {
            InitializeComponent();
            _uye = uye;
            _context = context;
            _listeYenile = listeYenile;

            txtNumara.Text = _uye.ID.ToString();
            txtAdSoyad.Text = _uye.AdSoyad;
            txtEmail.Text = _uye.Email;
            txtDurum.Text = _uye.UyeStatus ? "Aktif" : "Pasif";

            toolTip1.SetToolTip(btnUpdate, "Üyeyi Düzenle");
            toolTip1.SetToolTip(btnSil, "Üyeyi Sil");
            toolTip1.SetToolTip(btnDetay, "Üye Bilgisi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                // Onay al
                var sonuc = MessageBox.Show($"{_uye.AdSoyad} adlı üyeyi silmek istediğinize emin misiniz?",
                                            "Silme Onayı",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

                if (sonuc == DialogResult.Yes)
                {
                    // Üyenin ilişkili işlemleri kontrol et
                    bool oduncVarMi = _context.OduncIslemleri.Any(o => o.UyeID == _uye.ID);
                    if (oduncVarMi)
                    {
                        MessageBox.Show("Bu üyeye ait ödünç işlemleri var. Önce bu işlemleri iptal edin!",
                                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Üyeyi sil
                    var uye = _context.Uyeler.Find(_uye.ID);
                    if (uye != null)
                    {
                        _context.Uyeler.Remove(uye); // Silme işlemi
                        _context.SaveChanges(); // Veritabanına kaydet

                        MessageBox.Show("Üye başarıyla silindi!", "Başarılı",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Listeyi yenile
                        _listeYenile?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("Üye bulunamadı!", "Hata",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            FrmMemberDetails memberDetails = new FrmMemberDetails(_uye);
            memberDetails.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmMemberUpdate memberUpdate = new FrmMemberUpdate(_uye, _context, _listeYenile);
            memberUpdate.ShowDialog();
        }
    }
}
