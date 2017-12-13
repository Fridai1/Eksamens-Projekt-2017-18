using Windows.UI.Xaml.Controls;

namespace TouchPoint.ViewModel
{
    public class BrugerDetailsVM : DetailsVMBase<Bruger>

    {
        public BrugerDetailsVM(Bruger obj) : base(obj)
        {
        }

        public string Name
        {
            get => DomainObject.Name;
            set => DomainObject.Name = value;
        }

        public string Fagområde
        {
            get => DomainObject.Field;
            set => DomainObject.Field = value;
        }

        public string Brugernavn
        {
            get => DomainObject.Username;
            set => DomainObject.Username = value;
        }

        public string Addresse
        {
            get => DomainObject.Address;
            set => DomainObject.Address = value;
        }

        public string Email
        {
            get => DomainObject.Email;
            set => DomainObject.Email = value;
        }

        public string Telefon
        {
            get => DomainObject.PhoneNr;
            set => DomainObject.PhoneNr = value;
        }

        public string Password
        {
            get => DomainObject.Password;
            set => DomainObject.Password = value;
        }

        public bool Underviser
        {
            get => DomainObject.IsTutor;
            set => DomainObject.IsTutor = value;
        }

        public bool Admin
        {
            get => DomainObject.IsAdmin;
            set => DomainObject.IsAdmin = value;
        }

        


    }
}