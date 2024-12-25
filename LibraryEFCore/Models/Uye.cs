using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFCore.Models
{
    public class Uye
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public required string AdSoyad { get; set; }

        [StringLength(15)]
        public string? Telefon { get; set; }

        [StringLength(100)]
        public required string Email { get; set; }

        [Required]
        public bool UyeStatus { get; set; }

        public DateTime UyeCreated { get; set; }

        public ICollection<OduncIslem>? OduncIslemler { get; set; } // İlişki

        public ICollection<Uyari>? Uyarilar { get; set; } // Yeni ilişki: Uyarılar
    }
}
