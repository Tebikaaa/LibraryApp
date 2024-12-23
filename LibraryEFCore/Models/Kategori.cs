using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFCore.Models
{
    public class Kategori
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public required string KategoriAdi { get; set; }

        public ICollection<Kitap>? Kitaplar { get; set; }
    }
}
