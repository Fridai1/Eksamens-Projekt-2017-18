using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TouchPoint.Annotations;
using TouchPoint.Controller;
using TouchPoint.ViewModel.Undervisningssted;
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
        protected List<T> _Catalog;
        private DetailsVMBase<T> _detailsVM;
        private bool _viewEnabled = false;

        

        
        
        
        

        private RelayCommand _createCommand;
        private RelayCommand _updateCommand;
        private RelayCommand _deleteCommand;
        private RelayCommand _saveCommand;

        public MasterDetailsVMBase(FactoryVMBase<T> FactoryVM)
        {
            _createCommand = new RelayCommand(Create,()=>true);
            _saveCommand = new RelayCommand(Save, () => true);
            _updateCommand = new RelayCommand(update,()=>true);
            _deleteCommand = new RelayCommand(Delete,()=>true);
            _Catalog = new List<T>();
            _vMFactory = FactoryVM;
            _masterVM = _vMFactory.CreateMasterViewModel();


           
        }

        


        public ObservableCollection<ItemVMBase<T>> ItemVMCollection
        {
            get => _masterVM.CreateItemVMCollection(_vMFactory, _Catalog);
        }

        public virtual ItemVMBase<T> ItemVMSelected
        {
            get
            {
                FieldsEnabled = false;
                OnPropertyChanged(nameof(FieldsEnabled));
                return _itemVMSelected;
            }
            set
            {
                _itemVMSelected = value;
                DetailsVM = CreateDetailsVM();
                OnPropertyChanged(nameof(DetailsVM));
                OnPropertyChanged(nameof(TrueIfSelected));
                OnPropertyChanged(nameof(USMasterDetailsVm.LokaleCollection));
                OnPropertyChanged(nameof(USMasterDetailsVm.SelectionChanged));
                
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

        public ICommand SaveCommand
        {
            get => _saveCommand;
        }

        public virtual void Create()
        {
            T ob = new T();
            ItemVMBase<T> obj = _vMFactory.ItemViewModel(ob);

            //_Catalog.Add(obj.DomainObject);
            ItemVMSelected = obj;
            FieldsEnabled = true;
            OnPropertyChanged(nameof(FieldsEnabled));
        }

        public virtual void update()
        {
            FieldsEnabled = true;
            OnPropertyChanged(nameof(FieldsEnabled));
        }

        // metode til at gemme et object
        public virtual void Save()
        {
            if (DetailsVM.DomainObject != null)
            {
                _Catalog.Add(DetailsVM.DomainObject);
                ItemVMSelected = null;
                FieldsEnabled = false;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FieldsEnabled));
                OnPropertyChanged(nameof(ItemVMCollection));
            }
            else
            {
                throw new NullReferenceException("der skal værer en bruger at gemme");
            }
        }

        public virtual void Delete()
        {
            _Catalog.Remove(ItemVMSelected.DomainObject);
            OnPropertyChanged(nameof(ItemVMCollection));
        }
        public bool TrueIfSelected
        {
            get
            {
                if (ItemVMSelected != null)
                {
                    return true;
                }

                return false;
            }
        }

        public bool FieldsEnabled
        {
            get => _viewEnabled;
            set => _viewEnabled = value;
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}