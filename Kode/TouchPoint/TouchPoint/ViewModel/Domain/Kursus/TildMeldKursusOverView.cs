using System.Windows.Input;
using Command.Implementation;
using TouchPoint.ViewModel.Base;
using TouchPoint.ViewModel.Kursus;

namespace TouchPoint.ViewModel.Domain.TilmeldKursus
{
    public class TildMeldKursusOverView : GodBase<KursusMasterDetailsVm>
    {
        private RelayCommand _tilmeldBruger;
        public TildMeldKursusOverView()
        {
            _tilmeldBruger = new RelayCommand(Brugertilmeldt,()=>true);
        }

        public ICommand TilmeldBrugerCommand
        {
            get => _tilmeldBruger;
        }

        private void Brugertilmeldt()
        {
            MasterDetails.DetailsVM.DomainObject.TilmeldBruger(GetLoggedInUSer);
        }
        
    }
}