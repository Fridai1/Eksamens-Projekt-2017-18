namespace TouchPoint.ViewModel
{
    public class BrugerItemVM : ItemVMBase<Bruger>
    {
        public BrugerItemVM(Bruger Obj) : base(Obj)
        {
        }

        public string Name
        {
            get => DomainObject.Name;
        }

        public string Fagområde
        {       
            get => DomainObject.Field;
        }

        public string Brugernavn
        {
            get => DomainObject.Username;
        }


        public override string Description
        {
            get => $"Navn: {Name}        Brugernavn: {Brugernavn}         Fagområde: {Fagområde}";
        }

        
    }
}