using System.Collections.Generic;
using System.Collections.ObjectModel;
using ViewModel.Interfaces;

namespace TouchPoint
{
    public class MasterVMBase<T> 
        where T : class
    {
        private ObservableCollection<ItemVMBase<T>> _ItemVMCollection;
        

        public MasterVMBase()
        {
            _ItemVMCollection = new ObservableCollection<ItemVMBase<T>>();
        }

        public ObservableCollection<ItemVMBase<T>> CreateItemVMCollection(FactoryVMBase<T> factory,List<T> collection)
        {
            _ItemVMCollection.Clear();

            foreach (T Obj in collection)
            {
                _ItemVMCollection.Add(factory.ItemViewModel(Obj));
            }
            return _ItemVMCollection;
        }
    }
}