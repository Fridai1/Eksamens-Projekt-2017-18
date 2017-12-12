using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.ViewModel.Domain.EkstraMateriale
{
    class EMItemVm : ItemVMBase<Model.EkstraMateriale>
    {
        public EMItemVm(Model.EkstraMateriale Obj) : base(Obj)
        {
        }

        public string Name
        {
            get => DomainObject.Navn;
        }
    }
}
