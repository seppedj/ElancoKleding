using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Ontwerp
    {
        //private properties
        private int _ontwerpID;
        private string _maat;

        //publieke properties
        public int OntwerpID
        {
            get { return _ontwerpID; }
            set { _ontwerpID = value; }
        }

        public string Maat
        {
            get { return _maat; }
            set { _maat = value; }
        }

        //publieke methodes
        public void geefMaat()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return _maat;

        }

        //constructor
        public Ontwerp()
        {

        }
    }
}