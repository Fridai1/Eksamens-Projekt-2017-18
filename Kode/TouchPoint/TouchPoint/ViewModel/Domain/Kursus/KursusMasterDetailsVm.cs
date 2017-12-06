namespace TouchPoint.ViewModel.Kursus
{
    public class KursusMasterDetailsVm : MasterDetailsVMBase<TouchPoint.Kursus>
    {
        public KursusMasterDetailsVm() : base(new KursusFactory())
        {
        }
    }
}