using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryEFCore.Context
{
    public class LibraryContext : DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<OduncIslem> OduncIslemleri { get; set; }

        public DbSet<SeriNo> SeriNolar { get; set; }

        // Veritabanı bağlantısı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // SQLite yerel veritabanı bağlantısı
                optionsBuilder.UseSqlite("Data Source=KutuphaneDB.sqlite");
            }
        }
    }
}
