using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Kraag
    {

        //private properties
        private int _kraagID;
        private string _type;
        private string _contrast;
        //publieke properties
        public int KraagID
        {
            get { return _kraagID; }
            set { _kraagID = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Contrast
        {
            get { return _contrast; }
            set { _contrast = value; }
        }

        //publieke methodes
        public void geefKraagType()
        {
            throw new System.NotImplementedException();
        }

        public void geefContrast()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return _type;
             
        }
        //constructors
        public Kraag(int pID, string pKraag)
        {
            _kraagID = pID;
            _type = pKraag;
        }

        public Kraag()
        {

        }
    }
}