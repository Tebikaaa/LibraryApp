using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Basiss;
using Microsoft.EntityFrameworkCore;

namespace LibraryUI.Forms.SubForms.Book
{
    public partial class FrmBookUpdate : Form
    {
        private readonly LibraryContext _context;
        private readonly Kitap _kitap;
        private readonly Action _onUpdate;

        public FrmBookUpdate(Kitap kitap,LibraryContext context, Action onUpdate)
        {
            InitializeComponent();
            _context = context;
            _kitap = kitap;
            _onUpdate = onUpdate;
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

            var kategoriler = _context.Kategoriler.ToList();
            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "ID";
            cmbKategori.SelectedValue = _kitap.KategoriID;

            cmbDurum.DataSource = Enum.GetValues(typeof(KitapDurumu));
            cmbDurum.SelectedItem = _kitap.Durum;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var kitap = _context.Kitaplar.Find(_kitap.ID);

                if (kitap != null)
                {
                    kitap.KitapAdi = txtKitapAdi.Text;
                    kitap.Yazar = txtYazar.Text;
                    kitap.ISBN = txtISBN.Text;
                    kitap.YayınYılı = int.TryParse(txtYayinYili.Text, out int yil) ? yil : (int?)null;

                    if (string.IsNullOrEmpty(kitap.SeriNo) || kitap.KategoriID != (int)cmbKategori.SelectedValue)
                    {
                        kitap.SeriNo = $"SN{cmbKategori.SelectedValue:D3}-{kitap.ID:D3}";
                    }

                    kitap.KategoriID = (int)cmbKategori.SelectedValue;
                    kitap.StokAdedi = (int)nudStokAdedi.Value;
                    kitap.Durum = (KitapDurumu)cmbDurum.SelectedItem;

                    _context.Kitaplar.Update(kitap);
                    _context.SaveChanges();

                    MessageBox.Show("Kitap başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _onUpdate?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kitap bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbKategori_DropDown(object sender, EventArgs e)
        {
            cmbKategori.DataSource = _context.Kategoriler.ToList();
        }

        private void nudStokAdedi_ValueChanged(object sender, EventArgs e)
        {
            if (nudStokAdedi.Value <= 0)
            {
                cmbDurum.SelectedItem = KitapDurumu.Yok;
            }
        }
    }
}
