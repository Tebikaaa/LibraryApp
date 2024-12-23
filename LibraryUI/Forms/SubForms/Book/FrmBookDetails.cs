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
using LibraryEFCore.Context;

namespace LibraryUI.Forms.SubForms
{
    public partial class FrmBookDetails : Form
    {
        private readonly Kitap _kitap;
        private readonly LibraryContext _context;

        // Yapıcı metod - Kitap verisini alır
        public FrmBookDetails(Kitap kitap, LibraryContext context)
        {
            InitializeComponent();
            _kitap = kitap; // Kitap nesnesini ata
            _context = context; // Veritabanı contextini ata
            BilgileriYukle(); // Bilgileri yükle
        }

        // Kitap bilgilerini forma yükle
        private void BilgileriYukle()
        {
            lblKitapAdi.Text = $"{_kitap.KitapAdi}";
            lblYazar.Text = $"{_kitap.Yazar}";
            lblISBN.Text = $"{_kitap.ISBN}";
            lblYayinYili.Text = $"{_kitap.YayınYılı?.ToString() ?? "Bilinmiyor"}";
            lblKategori.Text = $"{_kitap.Kategori.KategoriAdi}";
            lblStokAdedi.Text = $"{_kitap.StokAdedi}";
            lblDurum.Text = $"{_kitap.Durum}";

            // Seri Numaralarını Yükle
            var seriNolar = _context.SeriNolar
                .Where(s => s.KitapID == _kitap.ID)
                .Select(s => s.SeriNoKodu)
                .ToList();

            
            cmbSeriNolar.DataSource = seriNolar;
            cmbSeriNolar.DropDownStyle = ComboBoxStyle.DropDownList;// ListBox kontrolü eklendiğini varsayıyoruz.
        }
    }
}
