using System.Collections.ObjectModel;
using System.ComponentModel;
using DataTransformation.Interfaces;
using ViewModel.Implementation;
using ViewModel.Interfaces;

namespace TouchPoint
{
    public abstract class DetailsVMBase<T>
        where T : class
    {
        public T domainObject;
        public DetailsVMBase(T obj)
        {
            domainObject = obj;
        }

        public T DomainObject
        {
            get => domainObject;
        }
        
    }
}