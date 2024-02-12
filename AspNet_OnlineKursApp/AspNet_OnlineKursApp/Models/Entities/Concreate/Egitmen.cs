using AspNet_OnlineKursApp.Models.Entities.Abstract;

namespace AspNet_OnlineKursApp.Models.Entities.Concreate
{
    public class Egitmen:Kisi
    {
        public DateTime ISeBaslamaTarihi { get; set; }
        public DateTime IstenAyrilmaTarihi { get; set; }
    }
}
