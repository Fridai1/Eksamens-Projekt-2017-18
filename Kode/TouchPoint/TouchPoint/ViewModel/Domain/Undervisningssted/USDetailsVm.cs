using System.Collections.Generic;

namespace TouchPoint.ViewModel.Undervisningssted
{
    public class USDetailsVm : DetailsVMBase<TouchPoint.Undervisningssted>
    {
        public USDetailsVm(TouchPoint.Undervisningssted obj) : base(obj)
        {
        }

        public string Name
        {
            get => DomainObject.Name;
            set => DomainObject.Name = value;
        }
        public string Adress
        {
            get => DomainObject.Address;
            set => DomainObject.Address = value;
        }
        public int Phone
        {
            get => DomainObject.Phone;
            set => DomainObject.Phone = value;
        }
        public string Email
        {
            get => DomainObject.Email;
            set => DomainObject.Email = value;
        }

        public List<TouchPoint.Lokale> Rooms
        {
            get => DomainObject.Rooms;
            
        }

        public void AddRoom(TouchPoint.Lokale l)
        {
            DomainObject.Rooms.Add(l);
        }

    }
}