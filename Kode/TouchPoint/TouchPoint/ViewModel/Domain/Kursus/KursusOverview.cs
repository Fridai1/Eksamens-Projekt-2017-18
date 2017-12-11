using System.Collections.ObjectModel;
using System.Windows.Input;
using Command.Implementation;
using TouchPoint.ViewModel.Base;
using TouchPoint.ViewModel.Undervisningssted;

namespace TouchPoint.ViewModel.Kursus
{
    public class KursusOverview : GodBase<KursusMasterDetailsVm>
    {
        private USMasterDetailsVm _usMasterDetails;
        private BrugerMasterDetails _brugerMasterDetails;
        private RelayCommand _deleteTutor;
        private Bruger _selectedTutor;
        private BrugerMasterVM _tutorList;
        private BrugerFactory _brugerFactory;
       

        public KursusOverview() : base()
        {
            _usMasterDetails = new USMasterDetailsVm();   
            _brugerMasterDetails = new BrugerMasterDetails();
            // instancere et object kursus object med det samme - så at når opretkursus.xaml bliver instanceret og den instancere denne klasse med datacontext bliver der oprettet
            // et object der kan gemmes i.
            MasterDetails.DetailsVM = new KursusDetailsVm(new TouchPoint.Kursus());
            _deleteTutor = new RelayCommand(DeleteTutor,()=>true);
            _tutorList = new BrugerMasterVM();
            _brugerFactory = new BrugerFactory();
            
            
            //TutorList.Add(new BrugerItemVM(new Bruger("hans","asd","asd",22,"asd","asd",true,"asd", true)));

        }

        public USMasterDetailsVm UsMasterDetails
        {
            get => _usMasterDetails;
        }

        public BrugerMasterDetails BrugerMasterDetails
        {
            get => _brugerMasterDetails;
        }

        public ICommand DeleteTutorCommand
        {
            get => _deleteTutor;
        }

        public ObservableCollection<ItemVMBase<Bruger>> TutorList
        {
            get
            {
                if (MasterDetails.DetailsVM != null)
                {
                    return _tutorList.CreateItemVMCollection(_brugerFactory, MasterDetails.DetailsVM.DomainObject.Tutor);
                }
                return null;
            }
        } 

        public Bruger SelectedTutor
        {
            get => _selectedTutor;
            set
            {
                _selectedTutor = value;
                TutorToList();
            } 
        }

        public void TutorToList()
        {
            MasterDetails.DetailsVM.DomainObject.AddTutor(_selectedTutor);
            
            OnPropertyChanged(nameof(TutorList));
        }

        public void DeleteTutor()
        {
            MasterDetails.DetailsVM.DomainObject.Tutor.Remove(_selectedTutor);
            OnPropertyChanged(nameof(TutorList));
        }






    }
}