namespace TouchPoint.ViewModel.Undervisningssted.Lokale
{
    public class LokaleItemVm : ItemVMBase<TouchPoint.Lokale>
    {
        public LokaleItemVm(TouchPoint.Lokale Obj) : base(Obj)
        {
        }

        public string Name
        {
            get => DomainObject.Name;
            set => DomainObject.Name = value;
        }

        public override string Description
        {
            get => $"{Name}";
        }
    }
}