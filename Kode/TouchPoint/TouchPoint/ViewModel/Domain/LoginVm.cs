using System.Collections.Generic;
using System.Windows.Input;
using Command.Implementation;

namespace TouchPoint.ViewModel
{
    public static class LoginVm
    {
        private static RelayCommand _loginCommand;
        private static string _brugernavn;
        private static string _password;
        private static Dictionary<string, Bruger> _users;
        private static bool _authorize = false;
        private static Bruger _loggedinUser;

        static LoginVm()
        {
            _loginCommand = new RelayCommand(Login,()=>true);
            
        }

        public static ICommand LoginCommand
        {
            get => _loginCommand;
        }

        private static Bruger RequestUser()
        {

            // hent brugere fra database ind i en dict.

            //var users = (from database
            //             select new )

            return new Bruger();
        }

        

        public static Bruger GetLoggedInUser
        {
            get => _loggedinUser;
        }

        public static bool UserFound()
        {
            // check dict om user findes.
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
                return true;
                
            }
            else
            {
                return false;
            }
        }

        private static void login()
        {
            
        }
        public static void Logoff()
        {
            if (!_loggedinUser == null)
            {
                
            }
        }

        public static string Brugernavn
        {
            set => _brugernavn = value;
        }

        public static string Password
        {
            set => _password = value;
        }
    }
}