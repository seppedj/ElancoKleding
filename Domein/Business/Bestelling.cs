using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Bestelling
    {
        //private properties
        private int _bestellingID;
        private DateTime _datum;
        private string _omschrijving;
        private int _aantalexemplaren;
        //publieke properties

        public int BestellingID
        {
            get{return _bestellingID;}
            set { _bestellingID = value; }
        }

        public DateTime Datum
        {
            get { return _datum; }
            set { _datum = value; }
        }

        public string Omschrijving
        {
            get{ return _omschrijving; }
            set{ _omschrijving = value; }
        }

        public int aantalExemplaren
        {
            get { return _aantalexemplaren; }
            set { _aantalexemplaren = value; }
        }


        //publieke methodes
        public void geefOntwerpen()
        {
            throw new System.NotImplementedException();
        }

        public int geefAantal()
        {
            throw new System.NotImplementedException();
        }

        //constructor
        public Bestelling(int pbestelling, DateTime pdatum, string pomschrijving, int paantalex)
        {
            _bestellingID = pbestelling;
            _datum = pdatum;
            _omschrijving = pomschrijving;
            _aantalexemplaren = paantalex;
        }

        public Bestelling()
        {
                
        }
    }
}