namespace TouchPoint.ViewModel.Kursus
{
    public class KursusFactory : FactoryVMBase<TouchPoint.Kursus>
    {
        public override DetailsVMBase<TouchPoint.Kursus> CreateDetailsViewModel(TouchPoint.Kursus obj)
        {
            return new KursusDetailsVm(obj);
        }

        public override MasterVMBase<TouchPoint.Kursus> CreateMasterViewModel()
        {
            return new KursusMasterVm();
        }

        public override ItemVMBase<TouchPoint.Kursus> ItemViewModel(TouchPoint.Kursus obj)
        {
            return new KursusItemVm(obj);
        }
    }
}