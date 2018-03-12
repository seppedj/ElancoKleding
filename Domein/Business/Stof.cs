using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Stof
    {
        //private properties
        private int _stofID;
        private string _type;
        private string _kleur;

        //publieke properties
        public int StofID
        {
            get { return _stofID; }
            set { _stofID = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Kleur
        {
            get { return _kleur; }
            set { _kleur = value; }
        }

        //publieke methodes
        public void geefType()
        {
            throw new System.NotImplementedException();
        }

        public void geefKleur()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return _kleur;
            return _type;
        }

        //constructor
        public Stof(int pID, string pStof)
        {
            _stofID = pID;
            _type = pStof;
            
        }

        public Stof()
        {
            
        }
    }
}