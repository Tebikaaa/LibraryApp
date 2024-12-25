using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryEFCore.Basiss;

namespace LibraryEFCore.Models
{
    public class Uyari
    {
        [Key]
        public int ID { get; set; }


        public int UyeID { get; set; }
        public required Uye Uye { get; set; }

        public UyariTipi Tipi { get; set; }

        [Required]
        [StringLength(200)]
        public string UyariMesaji { get; set; } // Uyarı mesajı

        public DateTime UyariTarihi { get; set; } // Uyarı tarihi
    }

}
