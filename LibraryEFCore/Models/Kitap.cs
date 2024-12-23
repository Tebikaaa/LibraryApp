using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryUI.Basiss;

namespace LibraryEFCore.Models
{
    public class Kitap
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public required string KitapAdi { get; set; }

        [Required]
        [StringLength(100)]
        public required string Yazar { get; set; }

        [Required]
        [StringLength(13)]
        public required string ISBN { get; set; }

        public int? YayınYılı { get; set; }

        [Required]
        [StringLength(20)]
        public string SeriNo { get; set; }

        [ForeignKey("Kategori")]
        public int KategoriID { get; set; }
        public Kategori? Kategori { get; set; }

        public int StokAdedi { get; set; }

        public KitapDurumu Durum { get; set; } = KitapDurumu.Mevcut;
        public void GenerateSeriNo()
        {
            SeriNo = $"SN{KategoriID:D3}-{ID:D3}"; // SN + Kategori ID + Kitap ID
        }
    }
}
