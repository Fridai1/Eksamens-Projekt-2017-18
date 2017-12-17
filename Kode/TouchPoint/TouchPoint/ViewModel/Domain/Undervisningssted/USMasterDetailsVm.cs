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
        private RelayCommand _addLokaleCommand;
        private LokaleMasterVm _lokaleMaster;
        private LokaleFactory _lokaleFactory;
        private LokaleItemVm _selectedLokale;
        private RelayCommand _deleteLokale;


        public USMasterDetailsVm() : base("EducationSite",new USFactoryVm())
        {
            _addLokaleCommand = new RelayCommand(CreateRoom, () => true);
            _deleteLokale = new RelayCommand(DeleteLokale,()=>true);
            _lokaleFactory = new LokaleFactory();
            _lokaleMaster = new LokaleMasterVm();
        }

        private void CreateRoom()
        {
            DetailsVM.DomainObject.CreateRoom(_lokale);
            OnPropertyChanged(nameof(LokaleCollection));
            OnPropertyChanged();
            _lokale = null;
        }

        public virtual LokaleItemVm LokaleSelected
        {
            get => _selectedLokale;
            set => _selectedLokale = value;
        }

        private void DeleteLokale()
        {
            DetailsVM.DomainObject.DeleteRoom(LokaleSelected.DomainObject);
            OnPropertyChanged(nameof(LokaleCollection));
        }
        public ICommand addLokaleCommand
        {
            get => _addLokaleCommand;
        }

        public ICommand DeleteLokaleCommand
        {
            get => _deleteLokale;
        }

        public ObservableCollection<ItemVMBase<TouchPoint.Lokale>> LokaleCollection
        {
            get
            {
                if (DetailsVM != null)
                {
                   return _lokaleMaster.CreateItemVMCollection(_lokaleFactory, DetailsVM.DomainObject.Rooms);
                }
                else
                {
                    return null;
                }
            }
        }
        public string Lokale
        {
            get => _lokale;
            set => _lokale = value;
        }
    }
}