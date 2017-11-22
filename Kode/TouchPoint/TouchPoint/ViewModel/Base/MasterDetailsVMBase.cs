using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TouchPoint.Annotations;
using ViewModel.Implementation;

namespace TouchPoint.ViewModel
{
    public class MasterDetailsVMBase<T> : INotifyPropertyChanged
        where T : class 
    {
        private FactoryVMBase<T> _viewModelFactory;
        private ItemVMBase<T> _itemViewModelSelected;
        private MasterVMBase<T> _masterViewModel;
        private List<T> _Catalog;

        public MasterDetailsVMBase()
        {
            
        }

        public ObservableCollection<ItemVMBase<T>> ItemVMCollection
        {
            get => _masterViewModel.CreateItemVMCollection(_viewModelFactory, _Catalog);
        }

        public ItemVMBase<T> ItemVMSelected
        {
            get => _itemViewModelSelected;
            set => _itemViewModelSelected = value;
            

    }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}