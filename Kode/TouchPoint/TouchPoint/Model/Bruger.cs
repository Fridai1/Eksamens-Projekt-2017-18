using Windows.UI.Xaml.Controls;

namespace TouchPoint
{
    public class Bruger : ISaveable
    {
        public Bruger()
        {
            
        }
        // #2 constructer til vi kan oprette brugere uden om UI.
        public Bruger(string username, string password, string name, string phoneNr, string address, bool isTutor, string email, string field, bool isAdmin, int id = 0)
        {
            _id = id;
            _name = name;
            _address = address;
            _email = email;
            _phoneNr = phoneNr;
            _username = username;
            _password = password;
            _isTutor = isTutor;
            _field = field;
            _isAdmin = isAdmin;

        }

        private int _id;
        private string _name;
        private string _address;
        private string _email;
        private string _phoneNr;
        private string _username;
        private string _password;
        private bool   _isTutor;
        private string _field;
        private bool   _isAdmin;


        public void Save()
        {
            
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public string PhoneNr
        {
            get => _phoneNr;
            set => _phoneNr = value;
        }

        public string Username
        {
            get => _username;
            set => _username = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public bool IsTutor
        {
            get => _isTutor;
            set => _isTutor = value;
        }

        public string Field
        {
            get => _field;
            set => _field = value;
        }

        public bool IsAdmin
        {
            get => _isAdmin;
            set => _isAdmin = value;
        }


        public int Id {
            get => _id;
            set => _id = value;
        }
    }
}