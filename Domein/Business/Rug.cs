using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Rug
    {
        //private properties
        private int _rugID;
        private string _plooi;
        private string _afwerking;

        //publieke methodes
        public int RugID
        {
            get { return _rugID; }
            set { _rugID = value; }
        }

        public string Plooi
        {
            get { return _plooi; }
            set { _plooi = value; }
        }

        public string Afwerking
        {
            get { return _afwerking; }
            set { _afwerking = value; }
        }

        //publieke methodes
        public List<string> geefPlooi()
        {
            throw new System.NotImplementedException();
        }

        public void geefAfwerken()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return _plooi;
            return _afwerking;

        }

        //constructor
        public Rug(int pID, string pAfwerking)
        {
            _rugID = pID;
            _afwerking = pAfwerking;
        }

        public Rug()
        {

        }
    }
}