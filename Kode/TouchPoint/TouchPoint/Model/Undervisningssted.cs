using System.Collections.Generic;

namespace TouchPoint
{
    public class Undervisningssted : ISaveable
    {
        public Undervisningssted()
        {
            _rooms = new List<Lokale>();
        }

        private string _name;
        private string _adress;
        private string _email;
        private int _phone;
        private List<Lokale> _rooms;


        

       

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Address
        {
            get => _adress;
            set => _adress = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public int Phone
        {
            get => _phone;
            set => _phone= value;
        }

        public List<Lokale> Rooms
        {
            get => _rooms;
        }

        public void CreateRoom(string RoomName)
        {
            _rooms.Add(new Lokale(RoomName));
        }

        public void DeleteRoom(Lokale l)
        {
            _rooms.Remove(l);
        }

        public int Id { get; set; }
    }
}