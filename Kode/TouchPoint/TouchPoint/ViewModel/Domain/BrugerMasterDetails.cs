using System.Threading;

namespace TouchPoint.ViewModel
{
    public class BrugerMasterDetails : MasterDetailsVMBase<Bruger>
    {
        public BrugerMasterDetails() : base(new BrugerFactory())
        {
            
        }
        
    }
}