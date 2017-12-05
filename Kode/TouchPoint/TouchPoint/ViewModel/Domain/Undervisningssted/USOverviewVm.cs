using TouchPoint.ViewModel.Undervisningssted.Lokale;

namespace TouchPoint.ViewModel.Undervisningssted
{
    public class USOverviewVm
    {
        private USMasterDetailsVm _masterDetails;
        private LokaleMasterDetailsVm _lokalerMasterDetails;
        public USOverviewVm()
        {
            _masterDetails = new USMasterDetailsVm();
            _lokalerMasterDetails = new LokaleMasterDetailsVm();

        }

        public USMasterDetailsVm MasterDetails
        {
            get => _masterDetails;
        }

        public LokaleMasterDetailsVm LokaleMasterDetails
        {
            get => _lokalerMasterDetails;
        }
    }
}