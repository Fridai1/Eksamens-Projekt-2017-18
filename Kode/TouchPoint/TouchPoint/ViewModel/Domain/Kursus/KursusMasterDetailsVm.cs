using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace TouchPoint.ViewModel.Kursus
{
    public class KursusMasterDetailsVm : MasterDetailsVMBase<TouchPoint.Kursus>
    {
        public KursusMasterDetailsVm() : base("Course",new KursusFactory())
        {
            
        }

        



        
    }
}