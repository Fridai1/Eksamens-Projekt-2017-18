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
            get => DomainObject.Name;
        }

        public string Adresse
        {
            get => DomainObject.Address;
        }

        public override string Description
        {
            get => $"Navn: {Name}    Adresse: {Adresse}";
        }
    }
}