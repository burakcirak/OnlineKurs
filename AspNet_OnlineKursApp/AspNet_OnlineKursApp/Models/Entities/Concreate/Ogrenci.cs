using AspNet_OnlineKursApp.Models.Entities.Abstract;

namespace AspNet_OnlineKursApp.Models.Entities.Concreate
{
    public class Ogrenci:Kisi
    {
        public virtual List<Egitim> Egitimler { get; set; }
    }

}
