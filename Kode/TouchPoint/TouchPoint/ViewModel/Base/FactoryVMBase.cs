using System.Collections.Generic;
using System.Collections.ObjectModel;
using DataTransformation.Implementation;
using DataTransformation.Interfaces;
using ViewModel.Interfaces;

namespace TouchPoint
{
    public abstract class FactoryVMBase<T> where T : class
    {
        public abstract DetailsVMBase<T> CreateDetailsViewModel(T obj);

        public abstract MasterVMBase<T> CreateMasterViewModel();

        public abstract ItemVMBase<T> ItemViewModel(T obj);
    }
}