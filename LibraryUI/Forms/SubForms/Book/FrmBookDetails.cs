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

namespace LibraryUI.Forms.SubForms
{
    public partial class FrmBookDetails : Form
    {
        private readonly Kitap _kitap;

        // Yapıcı metod - Kitap verisini alır
        public FrmBookDetails(Kitap kitap)
        {
            InitializeComponent();
            _kitap = kitap; // Kitap nesnesini ata
            BilgileriYukle(); // Bilgileri yükle
        }

        // Kitap bilgilerini forma yükle
        private void BilgileriYukle()
        {
            lblKitapAdi.Text = $"{_kitap.KitapAdi}";
            lblYazar.Text = $"{_kitap.Yazar}";
            lblISBN.Text = $"{_kitap.ISBN}";
            lblYayinYili.Text = $"{_kitap.YayınYılı?.ToString() ?? "Bilinmiyor"}";
            lblSeriNo.Text = $"{_kitap.SeriNo}";
            lblKategori.Text = $"{_kitap.Kategori.KategoriAdi}";
            lblStokAdedi.Text = $"{_kitap.StokAdedi}";
            lblDurum.Text = $"{_kitap.Durum}";
        }
    }
}
