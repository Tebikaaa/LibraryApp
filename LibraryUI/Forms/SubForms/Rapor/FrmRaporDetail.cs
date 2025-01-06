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

namespace LibraryUI.Forms.SubForms.Rapor
{
    public partial class FrmRaporDetail : Form
    {
        private readonly AppRapor _rapor;
        public FrmRaporDetail(AppRapor rapor)
        {
            InitializeComponent();
            _rapor = rapor;
            LoadDetails();
        }
        private void LoadDetails()
        {
            lblNumara.Text = _rapor.Id.ToString(); // ID
            lblTarih.Text = _rapor.Tarih.ToString("dd MMM yyyy HH:mm:ss"); // Tarih
            listBoxRapor.Text = _rapor.Description; // Açıklama
        }

    }
}
