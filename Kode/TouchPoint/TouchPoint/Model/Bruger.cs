namespace TouchPoint
{
    public class Bruger
    {
        public Bruger()
        {
            
        }

        private string _navn;
        private string _addresse;
        private string _email;
        private int _telefon;
        private string _brugernavn;
        private string _password;
        private bool _Underviser;
        private string _fagområde;
        private bool _admin;


        public void Save()
        {
            
        }

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        public string Addresse
        {
            get => _addresse;
            set => _addresse = value;
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

        public string Brugernavn
        {
            get => _brugernavn;
            set => _brugernavn = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public bool Underviser
        {
            get => _Underviser;
            set => _Underviser = value;
        }

        public string Fagområde
        {
            get => _fagområde;
            set => _fagområde = value;
        }

        public bool Admin
        {
            get => _admin;
            set => _admin = value;
        }

        





    }
}