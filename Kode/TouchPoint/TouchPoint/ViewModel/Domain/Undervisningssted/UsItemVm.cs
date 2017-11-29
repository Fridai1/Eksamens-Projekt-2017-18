using Windows.Storage;

namespace TouchPoint.ViewModel.Undervisningssted
{
    public class UsItemVm : ItemVMBase<TouchPoint.Undervisningssted>
    {
        public UsItemVm(TouchPoint.Undervisningssted Obj) : base(Obj)
        {

        }

        public string Name
        {
            get => DomainObject.Navn;
        }

        public string Adresse
        {
            get => DomainObject.Addresse;
        }

        public override string Description
        {
            get => $"Navn: {Name}    Adresse: {Adresse}";
        }
    }
}