using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.ViewModel.Domain.EkstraMateriale
{
     public class EMDetailsVm : DetailsVMBase<Model.EkstraMateriale>
    {
        public EMDetailsVm(Model.EkstraMateriale obj) : base(obj)
        {
        }

        public string Navn
        {
            get => DomainObject.Navn;
            set => DomainObject.Navn = value;
        }
    }
}
