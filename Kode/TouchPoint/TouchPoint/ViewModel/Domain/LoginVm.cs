using System.Collections.Generic;
using System.Windows.Input;
using Command.Implementation;

namespace TouchPoint.ViewModel
{
    public class LoginVm
    {
        private RelayCommand _loginCommand;
        private string _brugernavn;
        private string _password;
        private Dictionary<string, string> _users;
        private bool _authorize = false;
        public LoginVm()
        {
            _loginCommand = new RelayCommand(Login,()=>true);
            
        }

        public ICommand LoginCommand
        {
            get => _loginCommand;
        }

        private Bruger RequestUser()
        {
            // request user from database

            return new Bruger();
        }

        public void Login()
        {
            bool userfound = _users.ContainsKey(_brugernavn);

            if (userfound && _users.ContainsValue(_password))
            {
                _authorize = true;
            }
        }

        public string Brugernavn
        {
            set => _brugernavn = value;
        }

        public string Password
        {
            set => _password = value;
        }

    }
}