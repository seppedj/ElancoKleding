using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Borduur
    {
        //private properties
        private int _borduurID;
        private string _tekst;
        private int _plaats;
        private int _kleur;

        //publieke properties
        public int BorduurID
        {
            get { return _borduurID; }
            set { _borduurID = value; }
        }

        public string Tekst
        {
            get { return _tekst; }
            set { _tekst = value; }
        }

        public int Plaats
        {
            get { return _plaats; }
            set { _plaats = value; }
        }

        public int Kleur
        {
            get { return _kleur; }
            set { _kleur = value; }
        }

        //publieke methodes

            // ik werk met een lijst van strings omdat je eigenlijk de gegevens uit een lijst haalt
        //public List<string> geefPlaats()
        //{

        //    return;
        //}

        //public List<string> geefKleur()
        //{
        //    return;
        //}

        public override string ToString()
        {
            return _tekst;
            //return _plaats;
            //return _kleur;

        }
        //constructor
        public Borduur(int pID, int pplaatsID, int pKleurID)
        {
            _borduurID = pID;
            _plaats = pplaatsID;
            _kleur = pKleurID;
        }

        public Borduur()
        {

        }
    }
}