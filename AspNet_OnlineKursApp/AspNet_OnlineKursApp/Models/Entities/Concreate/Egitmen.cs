using AspNet_OnlineKursApp.Models.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNet_OnlineKursApp.Models.Entities.Concreate
{
    public class Egitmen:Kisi
    {
        public DateTime ISeBaslamaTarihi { get; set; }
        public DateTime IstenAyrilmaTarihi { get; set; }

        public virtual List<Egitim> Egitimler { get; set; }
        [NotMapped]
        public virtual List<Ogrenci> Ogrenciler { get; set; }
    }
}
