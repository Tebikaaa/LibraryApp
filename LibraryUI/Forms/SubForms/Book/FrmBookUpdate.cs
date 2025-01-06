using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibraryEFCore.Context;
using LibraryEFCore.DataAccess;
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
        private RaporRepository _raporRepository;

        public FrmBookUpdate(Kitap kitap, LibraryContext context, Action onUpdate)
        {
            InitializeComponent();
            _context = context;
            _kitap = kitap;
            _onUpdate = onUpdate;
            _raporRepository = new RaporRepository(_context);
            BilgileriYukle();
        }

        private void BilgileriYukle()
        {
            txtNumara.Text = _kitap.ID.ToString();
            txtKitapAdi.Text = _kitap.KitapAdi;
            txtYazar.Text = _kitap.Yazar;
            txtISBN.Text = _kitap.ISBN;
            txtYayinYili.Text = _kitap.YayınYılı?.ToString();
            nudStokAdedi.Value = _kitap.StokAdedi;

            // Kategori Listesi Yükle
            var kategoriler = _context.Kategoriler.ToList();
            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "ID";
            cmbKategori.SelectedValue = _kitap.KategoriID;

            // Seri Numaralarını Yükle
            var seriNolar = _context.SeriNolar
                .Where(s => s.KitapID == _kitap.ID)
                .Select(s => s.SeriNoKodu)
                .ToList();

            cmbSeriNolar.DataSource = seriNolar;

            // Varsayılan durum ayarla
            if (seriNolar.Count > 0)
            {
                cmbSeriNolar.SelectedIndex = 0;
                SeriNoDurumunuYukle(seriNolar[0]);
            }
        }

        private void SeriNoDurumunuYukle(string seriNo)
        {
            var seciliSeriNo = _context.SeriNolar.FirstOrDefault(s => s.SeriNoKodu == seriNo);
            if (seciliSeriNo != null)
            {
                cmbDurum.DataSource = Enum.GetValues(typeof(KitapDurumu));
                cmbDurum.SelectedItem = seciliSeriNo.Durum;
            }
        }

        private void cmbSeriNolar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeriNolar.SelectedItem != null)
            {
                SeriNoDurumunuYukle(cmbSeriNolar.SelectedItem.ToString());
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var kitap = _context.Kitaplar.Include(k => k.SeriNolar).FirstOrDefault(k => k.ID == _kitap.ID);

                if (kitap != null)
                {
                    kitap.KitapAdi = txtKitapAdi.Text;
                    kitap.Yazar = txtYazar.Text;
                    kitap.ISBN = txtISBN.Text;
                    kitap.YayınYılı = int.TryParse(txtYayinYili.Text, out int yil) ? yil : (int?)null;
                    if (cmbKategori.SelectedValue != null)
                    {
                        kitap.KategoriID = (int)cmbKategori.SelectedValue;
                    }
                    else
                    {
                        MessageBox.Show("Kategori Bulunamadı Seçilmemiş olabilir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    kitap.StokAdedi = (int)nudStokAdedi.Value;

                    // Seçilen seri numarasının durumunu güncelle
                    var seciliSeriNo = _context.SeriNolar.FirstOrDefault(s => s.SeriNoKodu == cmbSeriNolar.SelectedItem.ToString());
                    if (seciliSeriNo != null)
                    {
                        seciliSeriNo.Durum = (KitapDurumu)cmbDurum.SelectedItem;
                    }

                    int mevcutStok = kitap.SeriNolar.Count;

                    if (mevcutStok < kitap.StokAdedi)
                    {
                        for (int i = mevcutStok; i < kitap.StokAdedi; i++)
                        {
                            kitap.SeriNolar.Add(new SeriNo
                            {
                                KitapID = kitap.ID,
                                SeriNoKodu = $"SN-{kitap.ID:D3}-{i + 1:D3}"
                            });
                        }
                    }
                    else if (mevcutStok > kitap.StokAdedi)
                    {
                        var silinecekSeriNolar = kitap.SeriNolar
                            .OrderByDescending(s => s.ID)
                            .Take(mevcutStok - kitap.StokAdedi)
                            .ToList();

                        _context.SeriNolar.RemoveRange(silinecekSeriNolar);
                    }

                    _context.Kitaplar.Update(kitap);
                    _raporRepository.RaporEkle("Kitap Güncellendi " + $"{kitap.KitapAdi} kitabı güncellendi.");
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
