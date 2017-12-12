using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.ViewModel.Domain.EkstraMateriale
{
    class EMMasterDetailsVm : MasterDetailsVMBase<Model.EkstraMateriale>
    {
        public EMMasterDetailsVm() : base(new EMFactoryVm())
        {
        }
    }
}
