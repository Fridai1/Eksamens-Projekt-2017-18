namespace TouchPoint.ViewModel
{
    public class RegistrerMasterDetailsVm : MasterDetailsVMBase<Bruger>
    {
        public RegistrerMasterDetailsVm() : base(new BrugerFactory())
        {
        }

        
    }
}