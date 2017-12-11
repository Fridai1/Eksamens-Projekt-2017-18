using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Command.Implementation;
using TouchPoint.Annotations;

namespace TouchPoint.ViewModel.Base
{
    public class GodBase<T> : INotifyPropertyChanged
        where T : class, new()
    {
        T _masterDetails;
        private Bruger _loggedInBruger;
        private RelayCommand _logOffCommand;
        private bool _isSomeOneLoggedIn;

        public GodBase()
        {
            _masterDetails = new T();
            _loggedInBruger = LoginVm.LoggedInUser;
            _logOffCommand = new RelayCommand(LoginVm.Logoff,()=>true);
            _isSomeOneLoggedIn = LoginVm.IsSomeOneLoggedIn();
        }

        public Bruger GetLoggedInUSer
        {
            get => _loggedInBruger;
        }

        public bool IsSomeOneLoggedIn
        {
            get => _isSomeOneLoggedIn;
        }

        public ICommand LogOff
        {
            get => _logOffCommand;
        }

        public T MasterDetails
        {
            get => _masterDetails;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}