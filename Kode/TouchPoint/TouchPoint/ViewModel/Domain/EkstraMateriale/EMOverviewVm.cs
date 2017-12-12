using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.ViewModel.Domain.EkstraMateriale
{
    class EMOverviewVm
    {
        private EMMasterDetailsVm _masterDetails;

        public EMOverviewVm()
        {
            _masterDetails = new EMMasterDetailsVm();
        }

        public EMMasterDetailsVm MasterDetails
        {
            get => _masterDetails;
        }
    }
}
