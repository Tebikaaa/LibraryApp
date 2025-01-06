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
        public DbSet<AppRapor> AppRapors { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<OduncIslem> OduncIslemleri { get; set; }
        public DbSet<Uyari> Uyarilar {  get; set; }
        public DbSet<SeriNo> SeriNolar { get; set; }


        // Veritabanı bağlantısı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // SQLite yerel veritabanı bağlantısı
                optionsBuilder.UseSqlServer("Data Source=server;Initial Catalog=database;User ID=username;Password=pwd;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

    }
}
