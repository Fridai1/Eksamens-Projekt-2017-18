
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

        

        public List<Bruger> TutorList
        {
            get
            {
                List<Bruger> underviserList = new List<Bruger>();
                foreach (Bruger b in _Catalog)
                {
                    if (b.IsTutor)
                    {
                        underviserList.Add(b);
                    }

                }
                //underviserList.Add(new Bruger("berta", "asd", "asd", "12345678", "asd st. 3", false, "asd@asd.com", "asdery", true));
                //underviserList.Add(new Bruger("prop", "asd", "asd", "12345678", "asd st. 5", false, "asd@asd.dk", "asdery", true));
                return underviserList;
            }
        }
        
    }
}