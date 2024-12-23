using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryEFCore.Models;

namespace LibraryUI.Forms.SubForms.Category
{
    public partial class FrmCategoryDetails : Form
    {
        private readonly Kategori _kategori;

        public FrmCategoryDetails(Kategori kategori)
        {
            InitializeComponent();
            _kategori = kategori;
            LoadDetails();
        }

        private void LoadDetails()
        {
            lblNumara.Text = _kategori.ID.ToString();
            lblKategoriAdi.Text = _kategori.KategoriAdi;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
