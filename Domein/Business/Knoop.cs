using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domein
{
    public class Knoop
    {
        //private properties
        private int _knoopID;
        private double _grootte;
        private string _kleur;

        //publieke properties
        public int knoopID
        {
            get { return _knoopID; }
            set { _knoopID = value; }
        }

        public double Grootte
        {
            get { return _grootte; }
            set { _grootte = value; }
        }

        public string Kleur
        {
            get { return _kleur; }
            set { _kleur = value; }
        }

        //publieke methodes
        public void geefGrootte()
        {
            throw new System.NotImplementedException();
        }

        public void geefKleur()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            //return _grootte;
            return _kleur;
        }

        //constructors
        public Knoop()
        {

        }
    }
}