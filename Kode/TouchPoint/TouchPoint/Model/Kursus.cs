using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace TouchPoint
{
    public class Kursus
    {
        private string _navn;
        private string _courseDate;
        private ulong _timeStart;
        private ulong _timeEnd;
        private int _length;
        private string _priceDescription;
        private double _deposit;
        private int _spots;
        private string _targetAudience;
        private string _seminarDescription;
        private string _extraMaterial;
        private Undervisningssted _location;
        private List<Bruger> _tutor;
        private string _courseDescription;
        private string _prereg;
        private Image _coursePicture;
        private string _extHose;
        private double _price;



        public Kursus()
        {
            
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
        public string PriceDescription
        {
            get => _priceDescription;
            set => _priceDescription = value;
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
        public Image CoursePicture
        {
            get => _coursePicture;
            set => _coursePicture = value;
        }
        public string ExtHost
        {
            get => _extHose;
            set => _extHose = value;
        }
        public double Price
        {
            get => _price;
            set => _price = value;
        }



    }
}