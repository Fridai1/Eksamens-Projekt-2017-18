using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.ViewModel.Domain.EkstraMateriale
{
    class EMFactoryVm : FactoryVMBase<Model.EkstraMateriale>
    {
        public override DetailsVMBase<Model.EkstraMateriale> CreateDetailsViewModel(Model.EkstraMateriale obj)
        {
            return new EMDetailsVm(obj);
        }

        public override MasterVMBase<Model.EkstraMateriale> CreateMasterViewModel()
        {
            return new EMMasterVm();
        }

        public override ItemVMBase<Model.EkstraMateriale> ItemViewModel(Model.EkstraMateriale obj)
        {
            return new ItemVMBase<Model.EkstraMateriale>(obj);
        }
    }
}
