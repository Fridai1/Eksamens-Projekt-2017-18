namespace TouchPoint.ViewModel.Undervisningssted.Lokale
{
    public class LokaleDetailsVm : DetailsVMBase<TouchPoint.Lokale>
    {
        public LokaleDetailsVm(TouchPoint.Lokale obj) : base(obj)
        {
        }

        public string Name
        {
            get => DomainObject.Name;
            set => DomainObject.Name = value;
        }
    }
}