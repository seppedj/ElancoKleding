using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domein
{
    public class Mouwsplit
    {
        private int _mouwsplitID;

        public int MouwsplitID
        {
            get { return _mouwsplitID; }
            set { _mouwsplitID = value; }
        }

        private string _omschrijving;

        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }

        public Mouwsplit()
        {

        }

        public Mouwsplit(int pID, string pOmschrijving)
        {
            _mouwsplitID = pID;
            _omschrijving = pOmschrijving;
        }
    }

}
