using TouchPoint.ViewModel.Undervisningssted.Lokale;

namespace TouchPoint.ViewModel.Undervisningssted
{
    public class USOverviewVm
    {
        private USMasterDetailsVm _masterDetails;
        private LokaleMasterDetailsVm _lokalerMasterDetails;
        private Bruger _loggedInUser;
        public USOverviewVm()
        {
            _masterDetails = new USMasterDetailsVm();
            _lokalerMasterDetails = new LokaleMasterDetailsVm();
            _loggedInUser = LoginVm.LoggedInUser;

        }

        public USMasterDetailsVm MasterDetails
        {
            get => _masterDetails;
        }

        public LokaleMasterDetailsVm LokaleMasterDetails
        {
            get => _lokalerMasterDetails;
        }

        public Bruger GetLoggedInUSer
        {
            get => _loggedInUser;
        }
    }
}