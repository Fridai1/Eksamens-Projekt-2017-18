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
        public T DomainObject;
        public DetailsVMBase(T obj)
        {
            DomainObject = obj;
        }

        public virtual string Description
        {
            get { return "Der mangler en discription, overrride plz"; }
        }
        
    }
}