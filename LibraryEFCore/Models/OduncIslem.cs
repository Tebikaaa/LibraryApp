using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFCore.Models
{
    public class OduncIslem
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Uye")] // Foreign Key
        public int UyeID { get; set; }
        public required Uye Uye { get; set; }

        [ForeignKey("Kitap")] // Foreign Key
        public int KitapID { get; set; }
        public required Kitap Kitap { get; set; }

        public DateTime OduncTarihi { get; set; }

        public int KalanGun { get; set; }

        public bool OduncDurumu { get; set; }

        public string OduncAlmaTipi { get; set; }

        public DateTime? IadeTarihi { get; set; } // Nullable
    }
}
