namespace TouchPoint.ViewModel
{
    public class BrugerItemVM : ItemVMBase<Bruger>
    {
        public BrugerItemVM(Bruger Obj) : base(Obj)
        {
        }

        public string Name
        {
            get => DomainObject.Navn;
        }

        public string Fagområde
        {
            get => DomainObject.Fagområde;
        }

        public string Brugernavn
        {
            get => DomainObject.Brugernavn;
        }


    }
}