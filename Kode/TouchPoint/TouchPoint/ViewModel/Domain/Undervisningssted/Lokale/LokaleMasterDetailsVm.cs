﻿namespace TouchPoint.ViewModel.Undervisningssted.Lokale
{
    public class LokaleMasterDetailsVm : MasterDetailsVMBase<TouchPoint.Lokale>
    {
        public LokaleMasterDetailsVm() : base("Room",new LokaleFactory())
        {
        }
    }
}