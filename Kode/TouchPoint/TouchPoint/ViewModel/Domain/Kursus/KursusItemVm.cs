namespace TouchPoint.ViewModel.Kursus
{
    public class KursusItemVm : ItemVMBase<TouchPoint.Kursus>
    {
        public KursusItemVm(TouchPoint.Kursus Obj) : base(Obj)
        {
        }

        public string Navn
        {
            get => DomainObject.Navn;
        }

        public int Spots
        {
            get => DomainObject.Spots;
        }

        public string Nr1Tutor
        {
            get => DomainObject.Tutor[0].Navn;
        }
    }
}