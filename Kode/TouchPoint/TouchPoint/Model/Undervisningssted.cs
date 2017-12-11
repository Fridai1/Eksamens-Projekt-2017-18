using System.Collections.Generic;

namespace TouchPoint
{
    public class Undervisningssted : ISaveable
    {
        public Undervisningssted()
        {
            _lokaler = new List<Lokale>();
        }

        private string _navn;
        private string _adresse;
        private string _email;
        private int _telefon;
        private List<Lokale> _lokaler;


        

       

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        public string Addresse
        {
            get => _adresse;
            set => _adresse = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public int Telefon
        {
            get => _telefon;
            set => _telefon = value;
        }

        public List<Lokale> Lokaler
        {
            get => _lokaler;
        }

        public void OpretLokale(string LokaleNavn)
        {
            _lokaler.Add(new Lokale(LokaleNavn));
        }

        public void SletLokale(Lokale l)
        {
            _lokaler.Remove(l);
        }

        public int Id { get; set; }
    }
}