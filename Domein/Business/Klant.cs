using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Klant
    {
        //private properties
        private int _klantnummer;
        private string _naam;
        private string _voornaam;
        private string _adres;
        //private string _postcode;
        private string _telefoonnr;
        private string _wachtwoord;
        private string _mail;
        public int Klantnummer
        {
            get { return _klantnummer; }
            set { _klantnummer = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        //public string Postcode
        //{
        //    get { return _postcode; }
        //    set { _postcode = value; }
        //}

        public string telefoonnr
        {
            get { return _telefoonnr; }
            set { _telefoonnr = value; }
        }

        public string wachtwoord
        {
            get { return _wachtwoord; }
            set { _wachtwoord = value; }
        }

        public string mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        //publieke methodes
        public string geefEigenschappenklant()
        {
            throw new System.NotImplementedException();
        }

        public string geefWachtwoord()
        {
            throw new System.NotImplementedException();
        }

        public string geefMail()
        {
            throw new System.NotImplementedException();
        }

        

        //constructors
        public Klant(int pID, string pVoornaam, string pFamnaam, string pAdres, string pTelnummer, string pMail, string pWachtwoord)
        {
            _klantnummer = pID;
            _voornaam = pVoornaam;
            _naam = pFamnaam;
            _adres = pAdres;
            _telefoonnr = pTelnummer;
            _mail = pMail;
            _wachtwoord = pWachtwoord;
        }

        public Klant()
        {

        }
    }
}