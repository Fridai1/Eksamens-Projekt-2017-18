using System;
using System.Collections.Generic;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Command.Implementation;

namespace TouchPoint.ViewModel
{
    public class LoginVm
    {
        private RelayCommand _loginCommand;
        private string _brugernavn;
        private string _password;
        private Dictionary<string, Bruger> _users;
        
        private static Bruger _loggedinUser;

        public LoginVm()
        {
            _loginCommand = new RelayCommand(Login,()=>true);
            _users = new Dictionary<string, Bruger>();
            // test bruger
            _users.Add("hans", new Bruger("hans", "1234", "hans", "12345678", "skolevej", true, "mail@mail.dk", "reflex", false));
            
        }

        public  ICommand LoginCommand
        {
            get => _loginCommand;
        }

        private  Bruger RequestUser()
        {

            // hent brugere fra database ind i en dict.

            //var users = (from database
            //             select new )

            return new Bruger();
        }


        public static Bruger LoggedInUser
        {
            get => _loggedinUser;
        }

        public bool FindUser()
        {
            // check dict om user findes.
            if (_brugernavn == null)
            {
                // mangler exception
                throw new NotImplementedException();
            }
            
            bool userfound = _users.ContainsKey(_brugernavn);

            Bruger FoundUser = new Bruger();

            // hvis der findes en user med det brugernavn
            if (userfound)
            {
                // findes user gør vi Founduser li med den fundne user
                FoundUser = _users[_brugernavn];
            }
            // givet en user findes og password stemmer overens. skal der ske noget - enten return true eller return bruger - ubestemt
            if (userfound && FoundUser.Password == _password)
            {
                _loggedinUser = FoundUser;
                
                return true;


            }
            else
            {
                // throw exception
                _brugernavn = null;
                return false;
            }
        }

        public void Login()
        {
            FindUser();
        }

        public static bool IsSomeOneLoggedIn()
        {
            return _loggedinUser != null;
        }

       


        public static void Logoff()
        {
            if (_loggedinUser != null)
            {
                _loggedinUser = null;
            }
            
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
    }
}