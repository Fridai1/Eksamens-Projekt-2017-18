using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Command.Implementation;
using TouchPoint.Annotations;
using TouchPoint.ViewModel.Undervisningssted.Lokale;

namespace TouchPoint.ViewModel.Undervisningssted
{
    public class USOverviewVm : INotifyPropertyChanged
    {
        private USMasterDetailsVm _masterDetails;
        private LokaleMasterDetailsVm _lokalerMasterDetails;
        private Bruger _loggedInUser;
        private RelayCommand _tilføjLokaleCommand;
        public USOverviewVm()
        {
            _masterDetails = new USMasterDetailsVm();
            _lokalerMasterDetails = new LokaleMasterDetailsVm();
            _loggedInUser = LoginVm.LoggedInUser;
            _tilføjLokaleCommand = new RelayCommand(Opretlokale, ()=>true);
            
            

        }

        public USMasterDetailsVm MasterDetails
        {
            get => _masterDetails;
        }

        public LokaleMasterDetailsVm LokaleMasterDetails
        {
            get => _lokalerMasterDetails;
        }

        public string GetLoggedInUSer
        {
            get => _loggedInUser.Navn;
        }

        private void Opretlokale()
        {
            LokaleMasterDetails.Create();
            MasterDetails.DetailsVM.DomainObject.OpretLokale(LokaleMasterDetails.DetailsVM.DomainObject.Navn);
        }

        public ICommand TilføjLokale
        {
            get => _tilføjLokaleCommand;
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}