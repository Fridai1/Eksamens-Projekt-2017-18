using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TouchPoint.Annotations;
using TouchPoint.Controller;
using ViewModel.Implementation;
using RelayCommand = Command.Implementation.RelayCommand;

namespace TouchPoint.ViewModel
{
    public class MasterDetailsVMBase<T> : INotifyPropertyChanged
        where T : class, new()
    {
        private FactoryVMBase<T> _vMFactory;
        private ItemVMBase<T> _itemVMSelected;
        private MasterVMBase<T> _masterVM;
        private List<T> _Catalog;
        private DetailsVMBase<T> _detailsVM;

        private RelayCommand _createCommand;
        private RelayCommand _updateCommand;
        private RelayCommand _deleteCommand;

        public MasterDetailsVMBase()
        {
            _createCommand = new RelayCommand(Create, ()=>true);
        }

        public ObservableCollection<ItemVMBase<T>> ItemVMCollection
        {
            get => _masterVM.CreateItemVMCollection(_vMFactory, _Catalog);
        }

        public ItemVMBase<T> ItemVMSelected
        {
            get => _itemVMSelected;
            set
            {
                _itemVMSelected = value;
                DetailsVM = CreateDetailsVM();
                OnPropertyChanged(nameof(DetailsVM));
                OnPropertyChanged();
            } 

            

    }

        public DetailsVMBase<T> DetailsVM
        {
            get => _detailsVM;
            set
            {
                _detailsVM = value;
                OnPropertyChanged();
            }
        }

        public DetailsVMBase<T> CreateDetailsVM()
        {
            if (_itemVMSelected == null)
            {
                return null;
            }
            else
            {
                return _vMFactory.CreateDetailsViewModel(ItemVMSelected.DomainObject);
            }
        }

        public ICommand CreateCommand
        {
            get => _createCommand;
        }
        public ICommand UpdateCommand
        {
            get => _updateCommand;
        }
        public ICommand DeleteCommand
        {
            get => _deleteCommand;
        }

        public void Create()
        {
            T obj = new T();
            _Catalog.Add(obj);
            ItemVMSelected = obj;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}