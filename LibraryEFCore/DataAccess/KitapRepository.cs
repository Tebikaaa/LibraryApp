using LibraryEFCore.Context;
using LibraryEFCore.Models;
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
    }
}
