
using System.Collections.ObjectModel;
using System.ComponentModel;
using DataTransformation.Interfaces;
using ViewModel.Implementation;
using ViewModel.Interfaces;

namespace TouchPoint
{
    public class ItemVMBase<T>
        where T : class
    {
        public T DomainObject;
        public ItemVMBase(T Obj)
        {
            DomainObject = Obj;
        }

        public virtual string Description { get => "we er i base klassen"; }

        
            
    }
}