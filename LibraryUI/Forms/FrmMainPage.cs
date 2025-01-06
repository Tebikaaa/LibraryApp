using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryEFCore.Basiss;
using LibraryEFCore.Context;
using LibraryUI.Basiss;
using Microsoft.EntityFrameworkCore;
using Timer = System.Windows.Forms.Timer;

namespace LibraryUI.Forms
{
    public partial class FrmMainPage : Form
    {
        private readonly LibraryContext _context;
        private Timer _timer;
        public FrmMainPage()
        {
            InitializeComponent();
            _context = new LibraryContext();
            this.Load += FrmMainPage_Load;
            TimerSetup();
        }
        private void TimerSetup()
        {
            _timer = new Timer();
            _timer.Interval = 1000; // 1 saniyede bir yenile
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblCanliSaat.Text = DateTime.Now.ToString("HH:mm:ss"); // Saat, dakika ve saniye
        }
        private void FrmMainPage_Load(object? sender, EventArgs e)
        {
            DashboardVerileriYukle();
            SonRaporlariYukle();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
        private void SonRaporlariYukle()
        {
            try
            {
                listBoxRaporlar.Items.Clear();
                var raporlar = _context.AppRapors
                   .OrderByDescending(r => r.Tarih)
                   .Select(r => $"{r.Tarih:dd MMM yyyy} - {r.Description}")
                   .ToList();

                if(raporlar != null || raporlar.Count > 0)
                {
                    listBoxRaporlar.Items.Add("Tüm Raporlar:");
                    listBoxRaporlar.Items.AddRange(raporlar.ToArray());
                }
                // Rapor tablosundaki tüm raporları getir
                listBoxRaporlar.Items.Add("------------------------");

                // 1. Teslim Edilmeyen Kitaplar
                var gecikmisKitaplar = _context.OduncIslemleri
                    .Where(o => o.IadeTarihi < DateTime.Now && o.OduncDurumu == OduncDurumu.TeslimEdilmedi)
                    .Include(o => o.Kitap)
                    .Include(o => o.Uye)
                    .Select(o => $"{o.Kitap.KitapAdi} - {o.Uye.AdSoyad} - {o.IadeTarihi:dd MMM yyyy}")
                    .ToList();

                listBoxRaporlar.Items.Add("Teslim Edilmeyen Kitaplar:");
                listBoxRaporlar.Items.AddRange(gecikmisKitaplar.ToArray());
                listBoxRaporlar.Items.Add("------------------------");

                // 2. En Aktif Üyeler
                var aktifUyeler = _context.OduncIslemleri
                    .GroupBy(o => o.UyeID)
                    .OrderByDescending(g => g.Count())
                    .Select(g => $"{g.First().Uye.AdSoyad} - {g.Count()} Ödünç")
                    .Take(5)
                    .ToList();

                listBoxRaporlar.Items.Add("En Aktif Üyeler:");
                listBoxRaporlar.Items.AddRange(aktifUyeler.ToArray());
                listBoxRaporlar.Items.Add("------------------------");

                // 3. En Çok Okunan Kitaplar
                var enCokOkunanKitaplar = _context.OduncIslemleri
                    .GroupBy(o => o.KitapID)
                    .OrderByDescending(g => g.Count())
                    .Select(g => $"{g.First().Kitap.KitapAdi} - {g.Count()} kez ödünç alındı.")
                    .Take(5)
                    .ToList();

                listBoxRaporlar.Items.Add("En Çok Okunan Kitaplar:");
                listBoxRaporlar.Items.AddRange(enCokOkunanKitaplar.ToArray());
                listBoxRaporlar.Items.Add("------------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DashboardVerileriYukle()
        {
            // 1. İstatistikler
            lblKitapSayisi.Text = _context.Kitaplar.Count().ToString();
            lblMevcutKitapSayisi.Text = _context.SeriNolar.Count(s => s.Durum == KitapDurumu.Mevcut).ToString();
            lblTeslimEdilmeyenKitapSayisi.Text = _context.SeriNolar.Count(s => s.Durum == KitapDurumu.OduncAlindi).ToString();
            lblUyeSayisi.Text = _context.Uyeler.Count().ToString();
            lblGecikme.Text = _context.OduncIslemleri.Count(o => o.IadeTarihi < DateTime.Now && o.OduncDurumu == OduncDurumu.TeslimEdilmedi).ToString();

            // 2. En Çok Okunan Kitap
            var enCokOkunanKitap = _context.OduncIslemleri
                .GroupBy(o => o.KitapID)
                .OrderByDescending(g => g.Count())
                .Select(g => g.First().Kitap.KitapAdi)
                .FirstOrDefault();
            lblEnCokOkunanKitap.Text = enCokOkunanKitap ?? "Yok";

            // 3. En Çok Okunan Kategori
            var enCokOkunanKategori = _context.Kitaplar
                .GroupBy(k => k.Kategori.KategoriAdi)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();
            lblEnCokOkunanKategori.Text = enCokOkunanKategori ?? "Yok";

            // 4. En Çok Uyarılan Üye
            var enCokUyarilanUye = _context.Uyeler
                .OrderByDescending(u => u.Uyarilar.Count)
                .Select(u => u.AdSoyad)
                .FirstOrDefault();
            lblEnCokUyarilanUye.Text = enCokUyarilanUye ?? "Yok";

            // 5. Kitap Kurdu (En Çok Okuyan Üye)
            var kitapKurdu = _context.OduncIslemleri
                .GroupBy(o => o.UyeID)
                .OrderByDescending(g => g.Count())
                .Select(g => g.First().Uye.AdSoyad)
                .FirstOrDefault();
            lblKitapKurdu.Text = kitapKurdu ?? "Yok";

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
