using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.ViewModel.Domain.EkstraMateriale
{
    class EMDetailsVm
    {
        }

        public string Navn
        {
            get => DomainObject.Navn;
            set => DomainObject.Navn = value;
        }
    }
}
