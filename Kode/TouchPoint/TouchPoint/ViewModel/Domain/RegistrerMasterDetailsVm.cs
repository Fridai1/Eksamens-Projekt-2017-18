namespace TouchPoint.ViewModel
{
    public class RegistrerMasterDetailsVm : MasterDetailsVMBase<Bruger>
    {
        public RegistrerMasterDetailsVm() : base(new BrugerFactory())
        {
        }

        public override void Save()
        {
            base.Save();
        }

        public override void Create()
        {
            base.Create();
        }
    }
}