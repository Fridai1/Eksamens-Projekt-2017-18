namespace TouchPoint.ViewModel
{
    public class RegistrerMasterDetailsVm : MasterDetailsVMBase<Bruger>
    {
        public RegistrerMasterDetailsVm() : base("User",new BrugerFactory())
        {
        }

        
    }
}