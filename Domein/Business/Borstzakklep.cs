using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Borstzakklep
    {
        //private properties
        private int _borstzaklepID;
        private string _afwerking;

        //publieke methodes
        public int BorstzakklepID
        {
            get { return _borstzaklepID; }
            set { _borstzaklepID = value; }
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
        public Borstzakklep(int pID, string pAfwerking)
        {
            _borstzaklepID = pID;
            _afwerking = pAfwerking;
        }

        public Borstzakklep()
        {

        }
    }
}