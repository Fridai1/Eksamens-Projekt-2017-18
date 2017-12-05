using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchPoint.Model
{
    public class EkstraMateriale
    {
        private string _navn;

        public EkstraMateriale()
        {

        }

        public EkstraMateriale(string navn)
        {
            Navn = navn;
        }

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }
    }
}
