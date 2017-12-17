namespace TouchPoint.ViewModel
{
    public class RegistrerMasterDetailsVm : MasterDetailsVMBase<Bruger>
    {
        private Bruger _user;
        private BrugerFactory _factory;
        public RegistrerMasterDetailsVm() : base("User",new BrugerFactory())
        {
            _user = LoginVm.LoggedInUser;
            _factory = new BrugerFactory();
            EditLoggedInUser();
        }

        public void EditLoggedInUser()
        {
            if (_user != null)
            {
                ItemVMSelected = _factory.ItemViewModel(_user);
                // vi kalder update for at låse felterne op.
                update();
            }
        }
    }
}