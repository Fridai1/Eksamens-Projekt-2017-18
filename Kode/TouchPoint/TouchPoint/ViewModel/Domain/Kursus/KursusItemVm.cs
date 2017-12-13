namespace TouchPoint.ViewModel.Kursus
{
    public class KursusItemVm : ItemVMBase<TouchPoint.Kursus>
    {
        public KursusItemVm(TouchPoint.Kursus Obj) : base(Obj)
        {
        }

        public string Name
        {
            get => DomainObject.Name;
        }

        public int Spots
        {
            get => DomainObject.Spots;
        }

        public override string Description
        {
            get => $"Navn: {Name}  Pladser tilbage: {Spots}";
        }
    }
}