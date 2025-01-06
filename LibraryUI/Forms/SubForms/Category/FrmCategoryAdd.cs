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
using LibraryEFCore.DataAccess;
using LibraryEFCore.Models;

namespace LibraryUI.Forms.SubForms.Category
{
    public partial class FrmCategoryAdd : Form
    {
        private readonly LibraryContext _context;
        private readonly Action _listeYenile;
        private RaporRepository _raporRepository;
        public FrmCategoryAdd(Action listeYenile)
        {
            InitializeComponent();
            _context = new LibraryContext(); // Veritabanı bağlantısını kur
            _listeYenile = listeYenile;
            _listeYenile = listeYenile;
            _raporRepository = new RaporRepository(_context);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Boşluk kontrolü
                if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
                {
                    MessageBox.Show("Kategori adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Aynı isimde kategori kontrolü
                bool kategoriVarMi = _context.Kategoriler.Any(k => k.KategoriAdi == txtKategoriAdi.Text.Trim());
                if (kategoriVarMi)
                {
                    MessageBox.Show("Bu kategori zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Yeni kategori oluştur
                var yeniKategori = new Kategori
                {
                    KategoriAdi = txtKategoriAdi.Text.Trim() // Boşlukları temizle
                };

                // Veritabanına ekle
                _context.Kategoriler.Add(yeniKategori);
                _raporRepository.RaporEkle("Kategori "+ $"Yeni kategori eklendi: {yeniKategori.KategoriAdi}");
                _context.SaveChanges(); // Kaydet

                MessageBox.Show("Kategori başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Listeyi yenile ve formu kapat
                _listeYenile?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
