using System;
using System.Linq;
using LibraryEFCore.Context;
using LibraryEFCore.Models;

namespace LibraryEFCore.DataAccess
{
    public class RaporRepository
    {
        private readonly LibraryContext _context;

        public RaporRepository(LibraryContext context)
        {
            _context = context;
        }

        // Rapor ekleme metodu
        public void RaporEkle(string mesaj)
        {
            var yeniRapor = new AppRapor
            {
                Description = mesaj,
                Tarih = DateTime.Now
            };

            _context.AppRapors.Add(yeniRapor);
            _context.SaveChanges();
        }
    }
}
