using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LibraryUI.Basiss;
using LibraryEFCore.Models;

public class SeriNo
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(20)]
    public string SeriNoKodu { get; set; } // Benzersiz Seri No

    public int KitapID { get; set; } // Kitap ile ilişki
    public Kitap Kitap { get; set; }

    public KitapDurumu Durum{ get; set; }
    // Navigation Property
}
