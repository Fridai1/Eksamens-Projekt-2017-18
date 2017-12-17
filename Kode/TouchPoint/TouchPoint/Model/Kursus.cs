using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace TouchPoint
{
    public class Kursus : ISaveable
    {
        private string _navn;
        private string _courseDate;
        private ulong _timeStart;
        private ulong _timeEnd;
        private int   _length;
        private double _deposit;
        private int    _spots;
        private string _targetAudience;
        private string _seminarDescription;
        private string _extraMaterial;
        private Undervisningssted _location;
        private Lokale _lokale;
        private List<Bruger> _tutor;
        private string _courseDescription;
        private string _prereg;
        private double _price;
        private List<Bruger> _tilmeldteBrugere;



        public Kursus(string navn, string courseDate, ulong timeStart, ulong timeEnd,int length, int spots, string targetAudience, string seminarDescription, string extramateriale
            , Undervisningssted location,Bruger tutor, string courseDescription, string prereg, double price, int deposit)
        {
            _navn = navn;
            _courseDate = courseDate;
            _timeStart = timeStart;
            _timeEnd = timeEnd;
            _length = length;
            _deposit = deposit;
            _spots = spots;
            _targetAudience = targetAudience;
            _seminarDescription = seminarDescription;
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

        public string Navn
        {
            get => _navn;
            set => _navn = value;
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
            set
            {
                if (value > Deposit)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _deposit = value;
                }
            }
        }
        public int Spots
        {
            get => _spots;
            set => _spots = value;
        }
        public string Targetaudience
        {
            get => _targetAudience;
            set => _targetAudience = value;
        }
        public string SeminarDescription
        {
            get => _seminarDescription;
            set => _seminarDescription = value;
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

        

        public int Id { get; set; }
    }
}