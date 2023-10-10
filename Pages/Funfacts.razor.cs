namespace Voorbeeld.Pages
{
    public partial class Funfacts
    {
        public bool First { get; set; }
        public string Vandaag { get; set; }

        public string Geboren { get; set; }

        public string Sterven { get; set; }

        public string Dagen { get; set; }

        public DateTime Geboortedatum { get; set; }
        public TimeSpan dagen { get; set; }

        public Funfacts()
        {
            First = true;
        }

        public void GetFunfacts()
        {
            dagen = DateTime.Now - Geboortedatum;
            Vandaag = "Vandaag is het " + DateTime.Now.ToShortDateString();
            Geboren = "Je bent geboren op " + Geboortedatum.ToShortDateString();
            Sterven = "Je zal sterven op " + Geboortedatum.AddYears(80).ToShortDateString();
            Dagen = "Je leeft al " + dagen.TotalDays + " dagen";
            First = false;
        }
    }
}