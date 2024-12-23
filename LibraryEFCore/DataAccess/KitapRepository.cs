using LibraryEFCore.Context;
using LibraryEFCore.Models;
using LibraryUI.Basiss;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryEFCore.DataAccess
{
    public class KitapRepository : Repository<Kitap>
    {
        private readonly LibraryContext _context;

        public KitapRepository(LibraryContext context) : base(context)
        {
            _context = context;
        }

        // Özel sorgu: Kategoriye göre kitap listele
        public IEnumerable<Kitap> GetByCategory(int kategoriId)
        {
            return _context.Kitaplar.Where(k => k.KategoriID == kategoriId).ToList();
        }

        // Özel sorgu: Stokta olanları getir
        public IEnumerable<Kitap> GetAvailableBooks()
        {
            return _context.Kitaplar.Where(k => k.StokAdedi > 0).ToList();
        }

        // Dinamik Filtreleme Metodu
        public IEnumerable<Kitap> Filtrele(
            string? kategori = null,
            string? durum = null,
            string? stok = null,
            bool adaGoreAZ = true)
        {
            // Başlangıç sorgusu
            IQueryable<Kitap> kitaplar = _context.Kitaplar.Include(k => k.Kategori);

            // 1. Kategoriye Göre Filtre
            if (!string.IsNullOrWhiteSpace(kategori))
            {
                kitaplar = kitaplar.Where(k => k.Kategori.KategoriAdi.ToLower().Contains(kategori.ToLower()));
            }

            // 2. Duruma Göre Filtre
            if (!string.IsNullOrWhiteSpace(durum))
            {
                if (Enum.TryParse<KitapDurumu>(durum, out var durumEnum))
                {
                    kitaplar = kitaplar.Where(k => k.Durum == durumEnum);
                }
            }

            // 3. Stoka Göre Filtre
            if (!string.IsNullOrWhiteSpace(stok) && int.TryParse(stok, out int stokMiktari))
            {
                kitaplar = kitaplar.Where(k => k.StokAdedi >= stokMiktari);
            }

            // 4. Ada Göre Sıralama
            kitaplar = adaGoreAZ
                ? kitaplar.OrderBy(k => k.KitapAdi)
                : kitaplar.OrderByDescending(k => k.KitapAdi);

            return kitaplar.ToList();
        }
    }
}
