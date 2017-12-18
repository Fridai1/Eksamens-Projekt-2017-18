using System.Collections.ObjectModel;
using System.ComponentModel;
using DataTransformation.Interfaces;
using ViewModel.Implementation;
using ViewModel.Interfaces;
using TouchPoint.Controller;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.Foundation;

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

        public static async Task PresentMessageOk(string message, string actionText, RelayCommand userAction) {
            MessageDialog dialogue = new MessageDialog(message);
            dialogue.Commands.Add(new UICommand(actionText, userAction.Execute));
            await dialogue.ShowAsync();
        }
        
    }
}