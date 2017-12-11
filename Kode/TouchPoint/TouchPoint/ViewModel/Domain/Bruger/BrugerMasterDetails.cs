
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;


using TouchPoint.Database;


namespace TouchPoint.ViewModel
{
    public class BrugerMasterDetails : MasterDetailsVMBase<Bruger>
    {
        private BrugerFactory _factory;
       
        public BrugerMasterDetails() : base("User",new BrugerFactory())

        {
            _factory = new BrugerFactory();
            
        }

        public ObservableCollection<ItemVMBase<Bruger>> UnderviserListe
        {
            get
            {
                ObservableCollection<ItemVMBase<Bruger>> underviserList = new ObservableCollection<ItemVMBase<Bruger>>();
                foreach (Bruger b in _Catalog)
                {
                    if (b.Underviser)
                    {
                        
                        underviserList.Add(_factory.ItemViewModel(b));
                    }
                   
                }
                underviserList.Add(new ItemVMBase<Bruger>(new Bruger("berta", "asd", "asd", 22, "asd", "asd", true, "asd", true)));
                underviserList.Add(new ItemVMBase<Bruger>(new Bruger("prop", "asd", "asd", 22, "asd", "asd", true, "asd", true)));
                return underviserList;
            }
        }

        public List<Bruger> TutorList
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
                underviserList.Add(new Bruger("berta", "asd", "asd", 22, "asd", "asd", true, "asd", true));
                underviserList.Add(new Bruger("prop", "asd", "asd", 22, "asd", "asd", true, "asd", true));
                return underviserList;
            }
        }
        
    }
}