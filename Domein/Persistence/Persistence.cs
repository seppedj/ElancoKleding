using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Domein
{
    class Persistence
    {
        private string _connectionstring;
		
        public List<Bestelling> getBestelling()
        {
            List<Bestelling> gegevens = new List<Bestelling>();

            //connectie maken
            MySqlConnection conn = new MySqlConnection(_connectionstring);

            //commando/query maken
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblbestelling;", conn);

            //connectie openen
            conn.Open();

            //query uitvoeren
            MySqlDataReader Datareader = cmd.ExecuteReader();
            //++++
            while(Datareader.Read())
            {
                //gegevens uit de database halen
                int id = Convert.ToInt16(Datareader["BestellingNummer"]);
                DateTime datum = Convert.ToDateTime(Datareader["Datum"]);
                string omschrijving = Convert.ToString(Datareader["Omschrijving"]);
                int aantalstuks = Convert.ToInt16(Datareader["AantalStuks"]);

                Bestelling bestelling = new Bestelling(id, datum, omschrijving, aantalstuks);
                gegevens.Add(bestelling);
            }
            //connectie sluiten
            conn.Close();

            return gegevens;
        }

        public List<Borduur> getBorduring()
        {
            List<Borduur> gegevens = new List<Borduur>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);
            
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblborduring;", conn);
            
            conn.Open();
            
            MySqlDataReader Datareader = cmd.ExecuteReader();

            while(Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["BorduringID"]);
                int plaats = Convert.ToInt16(Datareader["IDPlaats"]);
                int kleur = Convert.ToInt16(Datareader["IDKleur"]);

                Borduur borduring = new Borduur(id, plaats, kleur);
                gegevens.Add(borduring);
            }
            
            conn.Close();

            return gegevens;
        }

        public List<Borstzak> getBorstzak()
        {
            List<Borstzak> gegevens = new List<Borstzak>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblborstzak;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["BorstzakID"]);
                string borstzakk = Convert.ToString(Datareader["Borstzak"]);
                
                Borstzak borstzakkk = new Borstzak(id, borstzakk);
                gegevens.Add(borstzakkk);
            }

            conn.Close();

            return gegevens;
        }

        public List<Borstzakklep> getBorstzakKlep()
        {
            List<Borstzakklep> gegevens = new List<Borstzakklep>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblzakklep;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["ZakklepID"]);
                string borstzakklep = Convert.ToString(Datareader["Zakklep"]);

                Borstzakklep borstzakkklep = new Borstzakklep(id, borstzakklep);
                gegevens.Add(borstzakkklep);
            }

            conn.Close();

            return gegevens;
        }

        public List<Design> getDesign()
        {
            List<Design> gegevens = new List<Design>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tbldesign;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["DesignID"]);
                string Fit = Convert.ToString(Datareader["Design"]);

                Design Design = new Design(id, Fit);
                gegevens.Add(Design);
            }

            conn.Close();

            return gegevens;
        }

        public List<Epaulet> getEpaulet()
        {
            List<Epaulet> gegevens = new List<Epaulet>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblschouder;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["SchouderID"]);
                string schouder = Convert.ToString(Datareader["SchouderEpaulet"]);

                Epaulet Epaulet = new Epaulet(id, schouder);
                gegevens.Add(Epaulet);
            }

            conn.Close();

            return gegevens;
        }

        public List<Klant> getKlant()
        {
            List<Klant> gegevens = new List<Klant>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblklant;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["Klantnummer"]);
                string voornaam = Convert.ToString(Datareader["Voornaam"]);
                string famnaam = Convert.ToString(Datareader["Familienaam"]);
                string adres = Convert.ToString(Datareader["Adres"]);
                string telnummer = Convert.ToString(Datareader["Telefoonnummer"]);
                string mail = Convert.ToString(Datareader["E-mail"]);
                string wachtwoord = Convert.ToString(Datareader["Wachtwoord"]);


                Klant Klant = new Klant(id, voornaam, famnaam, adres, telnummer, mail, wachtwoord);
                gegevens.Add(Klant);
            }

            conn.Close();

            return gegevens;
        }

        public List<Knoopsluiting> getKnoopsluiting()
        {
            List<Knoopsluiting> gegevens = new List<Knoopsluiting>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblknoopsluiting;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["KnoopsluitingID"]);
                string knoopsl = Convert.ToString(Datareader["Knoopsluiting"]);

                Knoopsluiting knoopsluiting = new Knoopsluiting(id, knoopsl);
                gegevens.Add(knoopsluiting);
            }

            conn.Close();

            return gegevens;
        }

        public List<Kraag> getKraag()
        {
            List<Kraag> gegevens = new List<Kraag>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblkraag;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["KraagID"]);
                string omschrijving = Convert.ToString(Datareader["Kraag"]);
                

                Kraag Kraag = new Kraag(id, omschrijving);
                gegevens.Add(Kraag);
            }

            conn.Close();

            return gegevens;
        }

        public List<LangeMouw> getLangeMouw()
        {
            List<LangeMouw> gegevens = new List<LangeMouw>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tbllangemouw;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["LangeMouwID"]);
                string omschrijving = Convert.ToString(Datareader["LangeMouw"]);

                LangeMouw Mouw = new LangeMouw(id, omschrijving);
                gegevens.Add(Mouw);
            }

            conn.Close();

            return gegevens;
        }

        public List<KorteMouw> getKorteMouw()
        {
            List<KorteMouw> gegevens = new List<KorteMouw>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblkortemouw;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["KorteMouwID"]);
                string omschrijving = Convert.ToString(Datareader["KorteMouw"]);

                KorteMouw Mouw = new KorteMouw(id, omschrijving);
                gegevens.Add(Mouw);
            }

            conn.Close();

            return gegevens;
        }

        public List<Polsboord> getPolsboord()
        {
            List<Polsboord> gegevens = new List<Polsboord>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblpolsboord;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["PolsboordID"]);
                string omschrijving = Convert.ToString(Datareader["Polsboord"]);

                Polsboord Polsboord = new Polsboord(id, omschrijving);
                gegevens.Add(Polsboord);
            }

            conn.Close();

            return gegevens;
        }

        public List<Postcode> getGemeente()
        {
            List<Postcode> gegevens = new List<Postcode>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblpostcode;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["PostcodeID"]);
                string omschrijving = Convert.ToString(Datareader["Postcode"]);
                string gemeente = Convert.ToString(Datareader["Gemeente"]);
                Postcode Gem = new Postcode(id, omschrijving, gemeente);
                gegevens.Add(Gem);
            }

            conn.Close();

            return gegevens;
        }

        public List<Rug> getRug()
        {
            List<Rug> gegevens = new List<Rug>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblrug;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["RugID"]);
                string omschrijving = Convert.ToString(Datareader["Rug"]);

                Rug Rug = new Rug(id, omschrijving);
                gegevens.Add(Rug);
            }

            conn.Close();

            return gegevens;
        }

        public List<Stof> getStof()
        {
            List<Stof> gegevens = new List<Stof>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblkwaliteitstof*;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["HemdStofID"]);
                string omschrijving = Convert.ToString(Datareader["HemdStof"]);
                

                Stof Stof = new Stof(id, omschrijving);
                gegevens.Add(Stof);
            }

            conn.Close();

            return gegevens;
        }

        public List<Kleur> getStofKleur()
        {
            List<Kleur> gegevens = new List<Kleur>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblkleurhemd;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["HemdKleurID"]);
                string omschrijving = Convert.ToString(Datareader["KleurCodeBedrijf"]);
                
                Kleur Kleur = new Kleur(id, omschrijving);
                gegevens.Add(Kleur);
            }

            conn.Close();

            return gegevens;
        }

        public List<Snit> getSnit()
        {
            List<Snit> gegevens = new List<Snit>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblSnit;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["SnitID"]);
                string omschrijving = Convert.ToString(Datareader["Snit"]);

                Snit snit = new Snit(id, omschrijving);
                gegevens.Add(snit);
            }

            conn.Close();

            return gegevens;
        }

        public List<Zoom> getZoom()
        {
            List<Zoom> gegevens = new List<Zoom>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblzoom;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["ZoomID"]);
                string omschrijving = Convert.ToString(Datareader["Zoom"]);

                Zoom zoom = new Zoom(id, omschrijving);
                gegevens.Add(zoom);
            }

            conn.Close();

            return gegevens;
        }

        public List<Mouwsplit> getMouwSplit()
        {
            List<Mouwsplit> gegevens = new List<Mouwsplit>();

            MySqlConnection conn = new MySqlConnection(_connectionstring);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM itn_kledingconf.tblmouwsplit;", conn);

            conn.Open();

            MySqlDataReader Datareader = cmd.ExecuteReader();

            while (Datareader.Read())
            {
                int id = Convert.ToInt16(Datareader["MouwSplitID"]);
                string omschrijving = Convert.ToString(Datareader["MouwSplit"]);

                Mouwsplit mouwsplit = new Mouwsplit(id, omschrijving);
                gegevens.Add(mouwsplit);
            }

            conn.Close();

            return gegevens;
        }


        public Persistence()
        {
            _connectionstring = "server = localhost; user id = root; database = itn_kledingconf; password = WN5945wu";
        }
    }
}
