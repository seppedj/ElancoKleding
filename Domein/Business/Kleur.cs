using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domein
{
    class Kleur
    {
        private int _kleurID;

        public int KleurID
        {
            get { return _kleurID; }
            set { _kleurID = value; }
        }

        private string _kleurcode;

        public string Kleurcode
        {
            get { return _kleurcode; }
            set { _kleurcode = value; }
        }

        public Kleur(int pID, string pKleur)
        {
            _kleurID = pID;
            _kleurcode = pKleur;
        }

        public Kleur()
        {
                
        }
    }
}
