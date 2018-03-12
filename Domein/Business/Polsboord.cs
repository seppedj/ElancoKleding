using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Polsboord
    {
        //private properties
        private int _polsboordID;
        private string _afwerking;
        private string _kleur;
        private string _mouwslplit;

        //publieke properties
        public int PolsboordID
        {
            get { return _polsboordID; }
            set { _polsboordID = value; }
        }

        public string Afwerking
        {
            get { return _afwerking; }
            set { _afwerking = value; }
        }

        public string Kleur
        {
            get { return _kleur; }
            set { _kleur = value; }
        }

        public string Mouwsplit
        {
            get { return _mouwslplit; }
            set { _mouwslplit = value; }
        }
        
        //publieke methodes
        public void geefAfwerking()
        {
            throw new System.NotImplementedException();
        }

        public void geefKleur()
        {
            throw new System.NotImplementedException();
        }

        

        // constructor
        public Polsboord(int pID, string pAfwerking)
        {
            _polsboordID = pID;
            _afwerking = pAfwerking;
        }

        public Polsboord()
        {

        }
    }
}