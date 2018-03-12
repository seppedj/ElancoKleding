using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Epaulet
    {
        //private properties
        private int _epauletID;
        private string _afwerking;

        //publieke methodes
        public int EpauletID
        {
            get { return _epauletID; }
            set { _epauletID = value; }
        }

        public string Afwerking
        {
            get { return _afwerking; }
            set { _afwerking = value; }
        }
        
        //publieke methodes
        public void geefAfwerking()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return _afwerking;

        }

        //constructor
        public Epaulet(int pID, string pAfwerking)
        {
            _epauletID = pID;
            _afwerking = pAfwerking;
        }

        public Epaulet()
        {

        }
    }
}