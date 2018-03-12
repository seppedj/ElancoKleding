using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Borstzak
    {
        //private propersties
        private int _borstzakID;
        private string _plooi;

        //publieke properties
        public int BorstzakID
        {
            get { return _borstzakID; }
            set { _borstzakID = value; }
        }

        public string Plooi
        {
            get { return _plooi; }
            set { _plooi = value; }
        }

        //publieke methodes
        public void geefBorstzakPlooi()
        {
            
        }

        public override string ToString()
        {
            return _plooi;

        }

        //constructor
        public Borstzak(int pid, string pplooi)
        {
            _borstzakID = pid;
            _plooi = pplooi;
        }

        public Borstzak()
        {

        }
    }
}