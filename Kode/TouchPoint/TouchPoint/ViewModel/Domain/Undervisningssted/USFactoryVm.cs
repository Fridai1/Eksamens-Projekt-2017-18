namespace TouchPoint.ViewModel.Undervisningssted
{
    public class USFactoryVm : FactoryVMBase<TouchPoint.Undervisningssted>
    {
        public override DetailsVMBase<TouchPoint.Undervisningssted> CreateDetailsViewModel(TouchPoint.Undervisningssted obj)
        {
            return new USDetailsVm(obj);
        }

        public override MasterVMBase<TouchPoint.Undervisningssted> CreateMasterViewModel()
        {
            return new USMasterVm();
        }

        public override ItemVMBase<TouchPoint.Undervisningssted> ItemViewModel(TouchPoint.Undervisningssted obj)
        {
            return new UsItemVm(obj);
        }
    }
}