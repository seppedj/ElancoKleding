using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Knoopsluiting
    {
        //private properties
        private int _knoopsluitingID;
        private string _afwerking;
        
        // publieke methodes 
        public int KnoopsluitingID
        {
            get { return _knoopsluitingID; }
            set { _knoopsluitingID = value; }
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

        //constructors
        public Knoopsluiting(int pID, string pAfwerking)
        {
            _knoopsluitingID = pID;
            _afwerking = pAfwerking;
        }

        public Knoopsluiting()
        {

        }
    }
}