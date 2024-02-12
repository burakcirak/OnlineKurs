namespace AspNet_OnlineKursApp.Models.Entities.Abstract
{
    public abstract class Kisi:BaseEntity
    {
        public Kisi()
        {
               
        }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string TcKimlikNo { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }




    }
}
