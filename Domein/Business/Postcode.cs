using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Postcode
    {
        //private properties
        private int _postcodeID;
        private string _postcode;
        private string _gemeente;
        
        //publieke properties
        public int PostcodeID
        {
            get { return _postcodeID; }
            set { _postcodeID = value; }
        }

        public string Ppostcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }

        public string Gemeente
        {
            get { return _gemeente; }
            set { _gemeente = value; }
        }
       

        //constructor
        public Postcode(int pID, string pPostcode, string pGemeente)
        {
            _postcodeID = pID;
            _postcode = pPostcode;
            _gemeente = pGemeente; 
        }
        public Postcode()
        {

        }
    }
}