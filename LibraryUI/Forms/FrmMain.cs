﻿using System;
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

        private void btnKitap_Click(object sender, EventArgs e)
        {
            FrmBook book = new FrmBook();
            FormYukle(book);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCategory category = new FrmCategory();
            FormYukle(category);
        }
    }
}