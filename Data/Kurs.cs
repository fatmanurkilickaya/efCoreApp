using System.ComponentModel.DataAnnotations;

namespace efCoreApp.Data
{
    public class Kurs{
        //id=> primary key
        [Key]
        public int KursId { get; set; }
        public string? Baslik { get; set; }
    
    }

}