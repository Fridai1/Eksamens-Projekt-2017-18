namespace TouchPoint.ViewModel.Undervisningssted.Lokale
{
    public class LokaleItemVm : ItemVMBase<TouchPoint.Lokale>
    {
        public LokaleItemVm(TouchPoint.Lokale Obj) : base(Obj)
        {
        }

        public string Name
        {
            get => DomainObject.Navn;
            set => DomainObject.Navn = value;
        }

        public override string Description
        {
            get => $"{Name}";
        }
    }
}