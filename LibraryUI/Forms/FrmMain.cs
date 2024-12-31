using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FormYukle(Form form)
        {
            pnlContainer.Controls.Clear(); // Önce paneli temizle
            form.TopLevel = false; // Ana form içinde açılacak
            form.Dock = DockStyle.Fill; // Paneli tamamen kapla
            pnlContainer.Controls.Add(form); // Panelin içine ekle
            form.Show(); // Formu göster
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KitapSayfaAc_Click(object sender, EventArgs e)
        {
            FrmBook book = new FrmBook();
            FormYukle(book);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void AnasayfaAc_Click(object sender, EventArgs e)
        {
            FrmMainPage mainPage = new FrmMainPage();
            FormYukle(mainPage);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMainPage mainPage = new FrmMainPage();
            FormYukle(mainPage);
        }

        private void UyeFormAc_Click(object sender, EventArgs e)
        {
            FrmMember frmMember = new FrmMember();
            FormYukle(frmMember);
        }
        private void TeslimFormAc_Click(object sender, EventArgs e)
        {
            FrmBookContract bookContract = new FrmBookContract();
            FormYukle(bookContract);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
