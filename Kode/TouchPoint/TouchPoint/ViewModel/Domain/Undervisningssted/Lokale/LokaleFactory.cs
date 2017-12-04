namespace TouchPoint.ViewModel.Undervisningssted.Lokale
{
    public class LokaleFactory : FactoryVMBase<TouchPoint.Lokale>
    {
        public override DetailsVMBase<TouchPoint.Lokale> CreateDetailsViewModel(TouchPoint.Lokale obj)
        {
            return new LokaleDetailsVm(obj);
        }

        public override MasterVMBase<TouchPoint.Lokale> CreateMasterViewModel()
        {
            return new LokaleMasterVm();
        }

        public override ItemVMBase<TouchPoint.Lokale> ItemViewModel(TouchPoint.Lokale obj)
        {
            return new LokaleItemVm(obj);
        }
    }
}