namespace TouchPoint
{
    public class Lokale : ISaveable
    {
        private string _name;
        public Lokale(string name)
        {
            _name = name;
        }

        public Lokale()
        {
            
        }

        

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Id { get; set; }
    }
}