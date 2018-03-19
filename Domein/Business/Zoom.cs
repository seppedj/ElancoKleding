using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domein
{
    class Zoom
    {
        private int _zoomID;

        public int ZoomID
        {
            get { return _zoomID; }
            set { _zoomID = value; }
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

        public Zoom()
        {

        }

        public Zoom(int pID, string pOmschrijving)
        {
            _zoomID = pID;
            _omschrijving = pOmschrijving;
        }
    }
}
