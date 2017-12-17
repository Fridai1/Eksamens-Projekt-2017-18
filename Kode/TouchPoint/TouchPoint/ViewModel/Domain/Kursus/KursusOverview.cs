using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Command.Implementation;
using TouchPoint.Database;
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
        private TouchPoint.Undervisningssted _selectedLocation;
        private BrugerMasterVM _tutorList;
        private BrugerFactory _brugerFactory;
        private USMasterVm _lokationList;
        private USFactoryVm _usFactory;
        private List<TouchPoint.Undervisningssted> _usList;
        private DatabaseFacade<TouchPoint.Undervisningssted> _usFacade;


        public KursusOverview() : base()
        {
            _usMasterDetails = new USMasterDetailsVm();   
            _brugerMasterDetails = new BrugerMasterDetails();
            // instancere et object kursus object med det samme - så at når opretkursus.xaml bliver instanceret og den instancere denne klasse med datacontext bliver der oprettet
            // et object der kan gemmes i.
           // MasterDetails.DetailsVM = new KursusDetailsVm(new TouchPoint.Kursus());
            _deleteTutor = new RelayCommand(DeleteTutor,()=>true);
            _tutorList = new BrugerMasterVM();
            _lokationList = new USMasterVm();
            _brugerFactory = new BrugerFactory();
            _usFactory = new USFactoryVm();
            _usFacade = new DatabaseFacade<TouchPoint.Undervisningssted>();
            _usList = new List<TouchPoint.Undervisningssted>();
           




           

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

        public ObservableCollection<ItemVMBase<TouchPoint.Undervisningssted>> LokationList
        {
            get => _usMasterDetails.ItemVMCollection;


        }

        public TouchPoint.Undervisningssted SelectedLokation
        {
            get => _selectedLocation;
            set
            {
                MasterDetails.DetailsVM.DomainObject.Location = value;
                _selectedLocation = value;

            }
        }

       

       

        public List<Lokale> LokaleList
        {
            get => SelectedLokation.Rooms;
            
        }

        public Lokale SelectedLokale
        {
            set => MasterDetails.DetailsVM.DomainObject.Lokale = value;
        }








    }
}