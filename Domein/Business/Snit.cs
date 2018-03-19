using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domein
{
    class Snit
    {
        private int _snitID;

        public int SnitID
        {
            get { return _snitID; }
            set { _snitID = value; }
        }

        private string _omschrijving;

        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }

        public override string ToString()
        {
            return _omschrijving;
        }


        public Snit()
        {

        }

        public Snit(int pID, string pOmschrijving)
        {
            _snitID = pID;
            _omschrijving = pOmschrijving;
        }
    }
}
