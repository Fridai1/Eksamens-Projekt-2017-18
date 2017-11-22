﻿using System.Collections.Generic;

namespace TouchPoint
{
    public class Undervisningssted
    {
        public Undervisningssted()
        {
            
        }

        private string _navn;
        private string _adresse;
        private string _email;
        private int _telefon;
        private List<Lokale> _lokaler;


        public void Save()
        {
            
        }

        public string PropertieFormat()
        {
            throw new System.NotImplementedException();
        }

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        public string Addresse
        {
            get => _adresse;
            set => _adresse = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public int Telefon
        {
            get => _telefon;
            set => _telefon = value;
        }

        public void OpretLokale(string LokaleNavn)
        {
            _lokaler.Add(new Lokale(LokaleNavn));
        }

        public void SletLokale(Lokale l)
        {
            _lokaler.Remove(l);
        }
    }
}