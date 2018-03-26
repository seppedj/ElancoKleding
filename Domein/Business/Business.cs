using System;
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
    
        public List<Kraag> getKraag()
        {
            
            return _persistence.getKraag();
        }

        public List<Borduur> getBorduur()
        {
            return _persistence.getBorduring();
        }

        public List<Borstzak> getBorstzak()
        {
            return _persistence.getBorstzak();
        }

        public List<Borstzakklep> getBorstzakKlep()
        {
            return _persistence.getBorstzakKlep();
        }

        public List<Design> getDesign()
        {
            return _persistence.getDesign();
        }

        public List<Epaulet> getSchouder()
        {
            return _persistence.getEpaulet();
        }

        public List<Knoopsluiting> getKnoopsluiting()
        {
            return _persistence.getKnoopsluiting();
        }

        public List<KorteMouw> getKorteMouw()
        {

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
