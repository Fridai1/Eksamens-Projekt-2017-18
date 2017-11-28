namespace TouchPoint.ViewModel
{
    public class BrugerFactory : FactoryVMBase<Bruger>
    {
        public override DetailsVMBase<Bruger> CreateDetailsViewModel(Bruger obj)
        {
            return new BrugerDetailsVM(obj);
        }

        public override MasterVMBase<Bruger> CreateMasterViewModel()
        {
            return new MasterVMBase<Bruger>();
        }

        public override ItemVMBase<Bruger> ItemViewModel(Bruger obj)
        {
            return new BrugerItemVM(obj);
        }
    }
}