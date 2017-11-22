using System.Windows.Input;

namespace TouchPoint.Controller
{
    public class CreateController<T>
        where T : class, new()
    {
        

        public CreateController()
        {
            
        }

        public void Create()
        {
            T item = new T();
            
        }
    }
}