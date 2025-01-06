using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Context;
using LibraryEFCore.Models;

namespace LibraryUI.Forms.SubForms.BookContract
{
    public partial class FrmBookContractDetails : Form
    {
        private readonly OduncIslem _oduncIslem;
        private readonly LibraryContext _context;

        // Yapıcı metod - Ödünç işlem verisini alır
        public FrmBookContractDetails(OduncIslem oduncIslem, LibraryContext context)
        {
            InitializeComponent();
            _oduncIslem = oduncIslem; // Ödünç işlemi nesnesini ata
            _context = context; // Veritabanı contextini ata
            BilgileriYukle(); // Bilgileri yükle
        }

        // Bilgileri forma yükle
        private void BilgileriYukle()
        {
            // Üye bilgilerini yükle
            txtUyeNumara.Text = _oduncIslem.Uye.ID.ToString();
            txtAdSoyad.Text = _oduncIslem.Uye.AdSoyad;
            txtEmail.Text = _oduncIslem.Uye.Email;
            txtTelefon.Text = _oduncIslem.Uye.Telefon ?? "-";

            // Kitap bilgilerini yükle
            txtKitapNumara.Text = _oduncIslem.Kitap.ID.ToString();
            txtKitapAdi.Text = _oduncIslem.Kitap.KitapAdi;
            txtYazar.Text = _oduncIslem.Kitap.Yazar;
            txtISBN.Text = _oduncIslem.Kitap.ISBN;
            txtSeriNo.Text = _context.SeriNolar
                .FirstOrDefault(s => s.KitapID == _oduncIslem.KitapID)?.SeriNoKodu ?? "-";

            // Ödünç alma bilgilerini yükle
            txtOduncNumara.Text = _oduncIslem.ID.ToString();
            txtAlindigiTarih.Text = _oduncIslem.OduncTarihi.ToLongDateString();
            txtGeriAlinacakTarih.Text = _oduncIslem.IadeTarihi?.ToLongDateString() ?? "-";
            txtOduncAlmaTipi.Text = _oduncIslem.OduncAlmaTipi;
            txtKalanGun.Text = _oduncIslem.KalanGun.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
