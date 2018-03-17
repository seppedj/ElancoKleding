using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domein
{
    class KorteMouw
    {
        private int _kortemouwID;

        public int KorteMouww
        {
            get { return _kortemouwID; }
            set { _kortemouwID = value; }
        }

        private string _omschrijving;

        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }

        public KorteMouw()
        {

        }

        public KorteMouw(int pID, string pOmschrijving)
        {
            _kortemouwID = pID;
            _omschrijving = pOmschrijving;
        }

        public override string ToString()
        {
            return _omschrijving;
        }
    }
}
