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
    public partial class FrmCategoryUpdate : Form
    {
        private readonly LibraryContext _context;
        private readonly Kategori _kategori;
        private readonly Action _onUpdate;
        private RaporRepository _raporRepository;
        public FrmCategoryUpdate(Kategori kategori, Action onUpdate)
        {
            InitializeComponent();
            _context = new LibraryContext();
            _kategori = kategori;
            _onUpdate = onUpdate;
            _raporRepository = new RaporRepository(_context);
            txtNumara.Text = _kategori.ID.ToString();
            txtKategoriAdi.Text = _kategori.KategoriAdi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kategori güncelleme işlemi
                _kategori.KategoriAdi = txtKategoriAdi.Text;
                _context.Kategoriler.Update(_kategori);
                _raporRepository.RaporEkle("Kategori güncellendi: " + _kategori.KategoriAdi);
                _context.SaveChanges();

                MessageBox.Show("Kategori başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _onUpdate?.Invoke(); // Güncelleme sonrası action çağır
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCategoryUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
