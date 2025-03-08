using System.ComponentModel.DataAnnotations;

namespace efCoreApp.Data
{
    public class KursKayit{
        //id=> primary key
        [Key]
        public int KayitId { get; set; }
        public int OgrenciId { get; set; }
        public int KursId { get; set; }
        public DateTime KayitTarihi { get; set; }
               
    }

}