using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Mouw
    {
        //private properties
        private int _mouwID;
        private string _afwerking;
        private string _mouwlengte;
        private string _zoom;
        private string _contrast;
        public int mouwID
        {
            get { return _mouwID; }
            set { _mouwID = value; }
        }

        public string Afwerking
        {
            get { return _afwerking; }
            set { _afwerking = value; }
        }

        public string Mouwlengte
        {
            get { return _mouwlengte; }
            set { _mouwlengte = value; }
        }

        public string Zoom
        {
            get { return _zoom; }
            set { _zoom = value; }
        }

        public string Contrast
        {
            get { return _contrast; }
            set { _contrast = value; }
        }

        //publieke methodes
        public void geefAfwerking()
        {
            throw new System.NotImplementedException();
        }

        public void geefMouwlengte()
        {
            throw new System.NotImplementedException();
        }

        public void geefZoom()
        {
            throw new System.NotImplementedException();
        }

        public void geefContrast()
        {
            throw new System.NotImplementedException();
        }

        //constructors
        public Mouw(int pID, string pLengte)
        {
            _mouwID = pID;
            _mouwlengte = pLengte;
        }

        public Mouw()
        {

        }
    }
}