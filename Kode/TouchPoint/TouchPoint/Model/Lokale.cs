namespace TouchPoint
{
    public class Lokale : ISaveable
    {
        public Lokale(string navn)
        {
            _navn = navn;
        }

        public Lokale()
        {
            
        }

        private string _navn;

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        public int Id { get; set; }
    }
}