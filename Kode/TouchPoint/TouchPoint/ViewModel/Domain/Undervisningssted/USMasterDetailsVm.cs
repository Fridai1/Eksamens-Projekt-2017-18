using Command.Implementation;

namespace TouchPoint.ViewModel.Undervisningssted
{
    public class USMasterDetailsVm : MasterDetailsVMBase<TouchPoint.Undervisningssted>
    {
        private RelayCommand _lokaleCommand;
        private string _lokale;
        public USMasterDetailsVm() : base(new USFactoryVm())
        {
            _lokaleCommand = new RelayCommand(AddLokale,()=>true);
        }

        public string Lokale
        {
            set => _lokale = value;
        }

        public void AddLokale()
        {
            
        }
    }
}