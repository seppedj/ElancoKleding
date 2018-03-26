using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domein
{
        public class LangeMouw
        {
            private int _langewouwID;

            public int LangeMouww
            {
                get { return _langewouwID; }
                set { _langewouwID = value; }
            }

            private string _omschrijving;

            public string Omschrijving
            {
                get { return _omschrijving; }
                set { _omschrijving = value; }
            }

            public LangeMouw(int pID, string pOmschrijving)
            {
                _langewouwID = pID;
                _omschrijving = pOmschrijving;
            }

            public LangeMouw()
            {

            }

            public override string ToString()
            {
                return _omschrijving;
            }
        }
    }

