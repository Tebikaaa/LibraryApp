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
using LibraryEFCore.Models;
using LibraryUI.Basiss;

namespace LibraryUI.Forms.SubForms.Book
{
    public partial class FrmBookUpdate : Form
    {
        private readonly Kitap _kitap;
        public FrmBookUpdate(Kitap kitap)
        {
            InitializeComponent();
            _kitap = kitap; // Parametre olarak alınan kitap nesnesi
            BilgileriYukle();
        }
        private void BilgileriYukle()
        {
            txtNumara.Text = _kitap.ID.ToString();
            txtKitapAdi.Text = _kitap.KitapAdi;
            txtYazar.Text = _kitap.Yazar;
            txtISBN.Text = _kitap.ISBN;
            txtYayinYili.Text = _kitap.YayınYılı?.ToString();
            txtSeriNo.Text = _kitap.SeriNo;
            nudStokAdedi.Value = _kitap.StokAdedi;

            // Kategori yükleme
            using (var context = new LibraryContext())
            {
                var kategoriler = context.Kategoriler.ToList();
                cmbKategori.DataSource = kategoriler;
                cmbKategori.DisplayMember = "KategoriAdi";
                cmbKategori.ValueMember = "ID";
                cmbKategori.SelectedValue = _kitap.KategoriID; // Seçili kategoriyi ayarla
            }

            // Durum yükleme (Enum)
            cmbDurum.DataSource = Enum.GetValues(typeof(KitapDurumu));
            cmbDurum.SelectedItem = _kitap.Durum; // Mevcut durumu seç
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (var context = new LibraryContext())
            {
                var kitap = context.Kitaplar.Find(_kitap.ID);

                if (kitap != null)
                {
                    kitap.KitapAdi = txtKitapAdi.Text;
                    kitap.Yazar = txtYazar.Text;
                    kitap.ISBN = txtISBN.Text;
                    kitap.YayınYılı = int.TryParse(txtYayinYili.Text, out int yil) ? yil : (int?)null;
                    kitap.SeriNo = txtSeriNo.Text;
                    kitap.KategoriID = (int)cmbKategori.SelectedValue;
                    kitap.StokAdedi = (int)nudStokAdedi.Value; // NumericUpDown'dan alınan değer
                    kitap.Durum = (KitapDurumu)cmbDurum.SelectedItem;

                    context.SaveChanges();
                    MessageBox.Show("Kitap başarıyla güncellendi!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kitap bulunamadı!");
                }
            }
        }


        private void cmbKategori_DropDown(object sender, EventArgs e)
        {
            using (var context = new LibraryContext())
            {
                cmbKategori.DataSource = context.Kategoriler.ToList();
            }
        }

        private void nudStokAdedi_ValueChanged(object sender, EventArgs e)
        {
            if(nudStokAdedi.Value <= 0)
            {
                cmbDurum.SelectedIndex = 1;
            }
        }
    }
}
