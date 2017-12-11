using TouchPoint.ViewModel.Base;
using TouchPoint.ViewModel.Undervisningssted;

namespace TouchPoint.ViewModel.Kursus
{
    public class KursusOverview : GodBase<KursusMasterDetailsVm>
    {
        private USMasterDetailsVm _usMasterDetails;
        private BrugerMasterDetails _brugerMasterDetails;

        public KursusOverview() : base()
        {
            _usMasterDetails = new USMasterDetailsVm();   
            _brugerMasterDetails = new BrugerMasterDetails();
        }

        public USMasterDetailsVm UsMasterDetails
        {
            get => _usMasterDetails;
        }

        public BrugerMasterDetails BrugerMasterDetails
        {
            get => _brugerMasterDetails;
        }
    }
}