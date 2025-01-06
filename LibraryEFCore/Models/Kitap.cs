using LibraryEFCore.Models;
using LibraryUI.Basiss;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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

    public int KategoriID { get; set; }
    public Kategori? Kategori { get; set; }

    public int StokAdedi { get; set; } // Toplam Stok


    // Navigation Property for SeriNo
    public ICollection<SeriNo> SeriNolar { get; set; } = new List<SeriNo>();
    public void GenerateSeriNo(int adet)
    {
        var seriNolar = new List<SeriNo>();
        for (int i = 0; i < adet; i++)
        {
            seriNolar.Add(new SeriNo
            {
                KitapID = ID,
                SeriNoKodu = $"SN-{ID:D3}-{i + 1:D3}" // SN-KitapID-KopyaNo
            });
        }
        SeriNolar = seriNolar;
    }
}
