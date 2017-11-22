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
            
        }
    }
}