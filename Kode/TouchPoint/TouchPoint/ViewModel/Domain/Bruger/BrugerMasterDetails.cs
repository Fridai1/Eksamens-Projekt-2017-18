using System.Threading;
using TouchPoint.Database;

namespace TouchPoint.ViewModel
{
    public class BrugerMasterDetails : MasterDetailsVMBase<Bruger>
    {
       
        public BrugerMasterDetails() : base("User",new BrugerFactory())
        {
            
        }
        
    }
}