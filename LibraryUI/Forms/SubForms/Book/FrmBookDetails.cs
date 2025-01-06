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
using LibraryUI.Basiss;

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

            // Seri Numaralarını Yükle
            var seriNolar = _context.SeriNolar
                .Where(s => s.KitapID == _kitap.ID)
                .Select(s => s.SeriNoKodu)
                .ToList();

            cmbSeriNolar.DataSource = seriNolar;
            cmbSeriNolar.DropDownStyle = ComboBoxStyle.DropDownList;

            // Seçili seri numarasının durumunu getir
            cmbSeriNolar.SelectedIndexChanged += CmbSeriNolar_SelectedIndexChanged;
            if (cmbSeriNolar.Items.Count > 0)
            {
                cmbSeriNolar.SelectedIndex = 0; // Varsayılan olarak ilk seri no seçili gelir
                GuncelleDurum(seriNolar[0]);
            }
        }

        // Seçili seri numarasının durumunu güncelle
        private void CmbSeriNolar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeriNolar.SelectedItem != null)
            {
                string seciliSeriNo = cmbSeriNolar.SelectedItem.ToString();
                GuncelleDurum(seciliSeriNo);
            }
        }

        private void GuncelleDurum(string seriNo)
        {
            var seri = _context.SeriNolar.FirstOrDefault(s => s.SeriNoKodu == seriNo);
            if (seri != null)
            {
                lblDurum.Text = seri.Durum == KitapDurumu.Mevcut ? "Mevcut" : "Ödünç Alındı";
            }
            else
            {
                lblDurum.Text = "Bilinmiyor";
            }
        }
    }
}
