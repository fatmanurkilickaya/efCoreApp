using System.ComponentModel.DataAnnotations;

namespace efCoreApp.Data
{
    public class Ogrenci{
        //id=> primary key
        [Key]
        public int OgrenciKimlik { get; set; }
        public string? OgrenciAdi { get; set; }
        public string? OgrenciSoyadi { get; set; }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }
    
    }

}