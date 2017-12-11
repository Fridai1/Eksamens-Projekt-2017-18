using System.Windows.Input;

namespace TouchPoint.ViewModel.Kursus
{
    public class KursusMasterDetailsVm : MasterDetailsVMBase<TouchPoint.Kursus>
    {
        public KursusMasterDetailsVm() : base("Course",new KursusFactory())
        {

        }

        



        
    }
}