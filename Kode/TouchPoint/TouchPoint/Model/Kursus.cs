using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace TouchPoint
{
    public class Kursus : ISaveable
    {
        private int _id;
        private string _name;
        private string _courseDate;
        private ulong _timeStart;
        private ulong _timeEnd;
        private int   _length;
        private double _deposit;
        private int    _spots;
        private string _extraMaterial;
        private Undervisningssted _location;
        private Lokale _lokale;
        private List<Bruger> _tutor;
        private string _courseDescription;
        private string _prereg;
        private double _price;
        private List<Bruger> _tilmeldteBrugere;

        public Kursus(string name, string courseDate, ulong timeStart, ulong timeEnd,int length, int spots, string extramateriale
            , Undervisningssted location,Bruger tutor, string courseDescription, string prereg, double price, int deposit, int id = 0)
        {
            _id = id
            _name = name;
            _courseDate = courseDate;
            _timeStart = timeStart;
            _timeEnd = timeEnd;
            _length = length;
            _deposit = deposit;
            _spots = spots;
            _extraMaterial = extramateriale;
            _location = location;
            _tutor = new List<Bruger>();
            _tutor.Add(tutor);
            _courseDescription = courseDescription;
            _prereg = prereg;
            _price = price;
            
            _tilmeldteBrugere = new List<Bruger>();
        }

        public Kursus()
        {
            _tutor = new List<Bruger>();
            _tilmeldteBrugere = new List<Bruger>();
        }
        
        public int Id {
        get { return _id; }
        set { _id = value; }
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string CourseDate
        {
            get => _courseDate;
            set => _courseDate = value;
        }
        public ulong TimeStart
        {
            get => _timeStart;
            set => _timeStart = value;
        }
        public ulong TimeEnd
        {
            get => _timeEnd;
            set => _timeEnd = value;
        }
        public int Length
        {
            get => _length;
            set => _length = value;
        }
        public double Deposit
        {
            get => _deposit;
            set => _deposit = value;

        }
        public int Spots
        {
            get => _spots;
            set => _spots = value;
        }
        
        public string CourseDescription
        {
            get => _courseDescription;
            set => _courseDescription = value;
        }
        public string ExtraMaterial
        {
            get => _extraMaterial;
            set => _extraMaterial = value;
        }
        public Undervisningssted Location
        {
            get => _location;
            set => _location = value;
        }
        public List<Bruger> Tutor
        {
            get => _tutor;
            set => _tutor = value;
        }
        public string Prereg
        {
            get => _prereg;
            set => _prereg = value;
        }
        public Lokale Lokale
        {
            get => _lokale;
            set => _lokale = value;
        }
        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public List<Bruger> TilmeldteBrugere
        {
            get => _tilmeldteBrugere;
        }

        public void AddTutor(Bruger b)
        {
            _tutor.Add(b);
        }

        public void DeleteTutor(Bruger b)
        {
            _tutor.Remove(b);
        }

        public void OneSpotTaken()
        {
            if (Spots >= 0)
            {
                _spots = _spots - 1;
            }
        }

        public void TilmeldBruger(Bruger b)
        {
            _tilmeldteBrugere.Add(b);
            OneSpotTaken();
        }

        public bool IsDepositPaid()
        {
            return _deposit == 0;
        }
    }
}