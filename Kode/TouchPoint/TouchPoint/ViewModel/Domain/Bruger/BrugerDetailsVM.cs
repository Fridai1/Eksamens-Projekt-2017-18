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
            get => DomainObject.Navn;
            set => DomainObject.Navn = value;
        }

        public string Fagområde
        {
            get => DomainObject.Fagområde;
            set => DomainObject.Fagområde = value;
        }

        public string Brugernavn
        {
            get => DomainObject.Brugernavn;
            set => DomainObject.Brugernavn = value;
        }

        public string Addresse
        {
            get => DomainObject.Addresse;
            set => DomainObject.Addresse = value;
        }

        public string Email
        {
            get => DomainObject.Email;
            set => DomainObject.Email = value;
        }

        public int Telefon
        {
            get => DomainObject.Telefon;
            set => DomainObject.Telefon = value;
        }

        public string Password
        {
            get => DomainObject.Password;
            set => DomainObject.Password = value;
        }

        public bool Underviser
        {
            get => DomainObject.Underviser;
            set => DomainObject.Underviser = value;
        }

        public bool Admin
        {
            get => DomainObject.Admin;
            set => DomainObject.Admin = value;
        }

        


    }
}