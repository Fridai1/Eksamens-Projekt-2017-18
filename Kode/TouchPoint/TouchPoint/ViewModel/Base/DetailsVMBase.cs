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
        private T _domainObject;
        public DetailsVMBase(T obj)
        {
            _domainObject = obj;
        }

        public T DomainObject
        {
            get => _domainObject;
            set => _domainObject = value;
        }
        
    }
}