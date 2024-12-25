using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Basiss;
using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Basiss;
using Microsoft.EntityFrameworkCore;

namespace LibraryUI.Forms.SubForms.Member
{
    public partial class FrmMemberAdd : Form
    {
        private readonly LibraryContext _context;
        private readonly Action _listeYenile;

        public FrmMemberAdd(LibraryContext context, Action listeYenile)
        {
            InitializeComponent();
            _context = context;
            _listeYenile = listeYenile;
            BilgileriHazirla(); // Bilgileri hazırlama işlemi
        }

        private void BilgileriHazirla()
        {
            // Üye durumlarını Enum'dan yükle
            cmbDurum.DataSource = Enum.GetValues(typeof(UyeDurumu));
            cmbDurum.SelectedIndex = 1; // Varsayılan olarak "Aktif" seçili gelir.
        }

        // Üye ekleme butonu işlemi
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Zorunlu alanları kontrol et
                if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Lütfen tüm zorunlu alanları doldurun!");
                    return;
                }

                // Email benzersiz mi kontrol et
                bool emailVarMi = _context.Uyeler.Any(u => u.Email == txtEmail.Text.Trim());
                if (emailVarMi)
                {
                    MessageBox.Show("Bu e-posta zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Yeni üye oluştur
                var yeniUye = new Uye
                {
                    AdSoyad = txtAdSoyad.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    UyeStatus = (UyeDurumu)cmbDurum.SelectedItem == UyeDurumu.Aktif, // Enum değerine göre durum belirle
                    UyeCreated = DateTime.Now
                };

                // Veritabanına ekle
                _context.Uyeler.Add(yeniUye);
                _context.SaveChanges(); // Kaydet

                MessageBox.Show("Üye başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _listeYenile?.Invoke(); // Listeyi yenile
                this.Close(); // Formu kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
