using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Command.Implementation;
using TouchPoint.ViewModel.Undervisningssted.Lokale;

namespace TouchPoint.ViewModel.Undervisningssted
{
    public class USMasterDetailsVm : MasterDetailsVMBase<TouchPoint.Undervisningssted>
    {
        private string _lokale;
        private RelayCommand _tilføjLokaleCommand;
        private LokaleMasterVm _lokaleMaster;
        private LokaleFactory _lokaleFactory;


        public USMasterDetailsVm() : base("EducationSite",new USFactoryVm())
        {
            _tilføjLokaleCommand = new RelayCommand(Opretlokale, () => true);
            
            _lokaleFactory = new LokaleFactory();
            _lokaleMaster = new LokaleMasterVm();
        }

        private void Opretlokale()
        {
            DetailsVM.DomainObject.OpretLokale(_lokale);
            OnPropertyChanged(nameof(LokaleCollection));
            OnPropertyChanged();
            _lokale = null;
        }
        public ICommand TilføjLokale
        {
            get => _tilføjLokaleCommand;
        }

        public ObservableCollection<ItemVMBase<TouchPoint.Lokale>> LokaleCollection
        {
            get
            {
                if (DetailsVM != null)
                {
                   return _lokaleMaster.CreateItemVMCollection(_lokaleFactory, DetailsVM.DomainObject.Lokaler);
                }
                else
                {
                    return null;
                }
                
            }

            
        }

        public void SelectionChanged()
        {
            
            
        }


        public string Lokale
        {
            get => _lokale;
            set => _lokale = value;
        }




    }
}