using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace TouchPoint.ViewModel.Kursus
{
    public class KursusDetailsVm : DetailsVMBase<TouchPoint.Kursus>
    {
        public KursusDetailsVm(TouchPoint.Kursus obj) : base(obj)
        {
        }

        public string Navn
        {
            get => DomainObject.Name;
            set => DomainObject.Name = value;
        }

        public string CourseDate
        {
            get => DomainObject.CourseDate;
            set => DomainObject.CourseDate = value;
        }
        public ulong TimeStart
        {
            get => DomainObject.TimeStart;
            set => DomainObject.TimeStart = value;
        }
        public ulong TimeEnd
        {
            get => DomainObject.TimeEnd;
            set => DomainObject.TimeEnd = value;
        }
        public int Length
        {
            get => DomainObject.Length;
            set => DomainObject.Length = value;
        }
        public double Deposit
        {
            get => DomainObject.Deposit;
            set => DomainObject.Deposit = value;
        }
        public int Spots
        {
            get => DomainObject.Spots;
            set => DomainObject.Spots = value;
        }
       
        public string CourseDescription
        {
            get => DomainObject.CourseDescription;
            set => DomainObject.CourseDescription = value;
        }
        public string ExtraMaterial
        {
            get => DomainObject.ExtraMaterial;
            set => DomainObject.ExtraMaterial = value;
        }
        public TouchPoint.Undervisningssted Location
        {
            get => DomainObject.Location;
            set => DomainObject.Location = value;
        }
        public List<Bruger> Tutor
        {
            get => DomainObject.Tutor;
            set => DomainObject.Tutor = value;
        }
        public string Prereg
        {
            get => DomainObject.Prereg;
            set => DomainObject.Prereg = value;
        }
        public double Price
        {
            get => DomainObject.Price;
            set => DomainObject.Price = value;
        }
    }
}