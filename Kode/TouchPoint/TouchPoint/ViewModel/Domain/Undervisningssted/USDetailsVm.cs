namespace TouchPoint.ViewModel.Undervisningssted
{
    public class USDetailsVm : DetailsVMBase<TouchPoint.Undervisningssted>
    {
        public USDetailsVm(TouchPoint.Undervisningssted obj) : base(obj)
        {
        }

        public string Name
        {
            get => DomainObject.Navn;
            set => DomainObject.Navn = value;
        }
        public string Adresse
        {
            get => DomainObject.Addresse;
            set => DomainObject.Addresse = value;
        }
        public int Telefon
        {
            get => DomainObject.Telefon;
            set => DomainObject.Telefon = value;
        }
        public string Email
        {
            get => DomainObject.Email;
            set => DomainObject.Email = value;
        }
    }
}