using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Design
    {

        //private properties
        private int _designID;
        private string _fit;

        public int DesignID
        {
            get { return _designID;}
            set { _designID = value; }
        }

        public string Fit
        {
            get { return _fit; }
            set { _fit = value; }
        }
        //publieke methodes
        public string geefFit()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return _fit;

        }

        //constructor
        public Design(int pID, string pFit)
        {
            _designID = pID;
            _fit = pFit;
        }

        public Design()
        {

        }
    }
}