﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domein
{
    public class Business
    {
        private Bestelling _bestelling;
        private Borduur _borduur;
        private Borstzak _borstzak;
        private Borstzakklep _borstzakklep;
        private Design _design;
        private Epaulet _epaulet;
        private Klant _klant;
        private Knoop _knoop;
        private Knoopsluiting _knoopsluiting;
        private Kraag _kraag;
        private Mouw _mouw;
        private Ontwerp _ontwerp;
        private Polsboord _polsboord;
        private Postcode _postcode;
        private Rug _rug;
        private Stof _stof;
        private Kleur _kleur;
        private Persistence _persistence;
    
        public List<Kraag> getTest()
        {
            
            return _persistence.getKraag();
        }

        
        private List<string> OmzettenToString(List<Kraag> lijstkraag)
        {
            List<string> lijstReturn = new List<string>();
            foreach (Kraag e in _persistence.getKraag())
            {
                lijstReturn.Add(e.ToString());
            }
            return lijstReturn;
        }



        public Business()
        {
           _bestelling = new Bestelling();
           _borduur = new Borduur();
           _borstzak = new Borstzak();
           _borstzakklep = new Borstzakklep();
           _design = new Design();
           _epaulet = new Epaulet();
           _klant = new Klant();
            _knoop = new Knoop();
            _knoopsluiting = new Knoopsluiting();
            _kraag = new Kraag();
            _mouw = new Mouw();
            _ontwerp = new Ontwerp();
            _polsboord = new Polsboord();
            _postcode = new Postcode();
            _rug = new Rug();
            _stof = new Stof();
            _kleur = new Kleur();
            _persistence = new Persistence();
        }
    }
}
