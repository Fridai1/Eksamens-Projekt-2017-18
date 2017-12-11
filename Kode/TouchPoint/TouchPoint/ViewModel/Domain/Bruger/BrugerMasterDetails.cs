
using System.Collections.Generic;
using System.Threading;


using TouchPoint.Database;


namespace TouchPoint.ViewModel
{
    public class BrugerMasterDetails : MasterDetailsVMBase<Bruger>
    {


       
        public BrugerMasterDetails() : base("User",new BrugerFactory())

        {
            
        }

        public List<Bruger> UnderviserListe
        {
            get
            {
                List<Bruger> underviserList = new List<Bruger>();
                foreach (Bruger b in _Catalog)
                {
                    if (b.Underviser)
                    {
                        underviserList.Add(b);
                    }
                   
                }
                return underviserList;
            }
        }
        
    }
}