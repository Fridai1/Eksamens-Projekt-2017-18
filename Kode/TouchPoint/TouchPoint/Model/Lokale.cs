﻿namespace TouchPoint
{
    public class Lokale
    {
        public Lokale(string navn)
        {
            _navn = navn;
        }

        public Lokale()
        {
            
        }

        private string _navn;

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }
    }
}