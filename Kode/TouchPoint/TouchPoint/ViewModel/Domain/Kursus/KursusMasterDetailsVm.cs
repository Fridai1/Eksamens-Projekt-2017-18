using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace TouchPoint.ViewModel.Kursus
{
    public class KursusMasterDetailsVm : MasterDetailsVMBase<TouchPoint.Kursus>
    {
        public KursusMasterDetailsVm() : base("Course",new KursusFactory())
        {
            TouchPoint.Kursus k = new TouchPoint.Kursus("kursus", "21-12-17", 22, 22, 22, 25, "designere", "dette er godt", "22", new TouchPoint.Undervisningssted(), new Bruger("hans", "asd", "asd", 22, "asd", "asd", true, "sda", false), "dette er awesome", "rig", new Image(), "asd", 23, 555);
            TouchPoint.Kursus l = new TouchPoint.Kursus("body", "12-1-18", 22, 22, 22, 22, "designere", "dette er godt", "22", new TouchPoint.Undervisningssted(), new Bruger("hans", "asd", "asd", 22, "asd", "asd", true, "sda", false), "dette er awesome", "rig", new Image(), "asd", 23, 555);
            _Catalog.Add(k);
            _Catalog.Add(l);
        }

        



        
    }
}