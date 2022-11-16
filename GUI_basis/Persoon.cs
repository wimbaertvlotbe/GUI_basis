using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI_basis
{

    public class Persoon
    {
        private string id;
        private string naam;
        private int leeftijd;

        public Persoon(string id, string naam, int leeftijd)
        {
            if (TestID(id)) this.id = id; 
            this.naam = naam;
            if (TestLeeftijd(leeftijd)) this.leeftijd = leeftijd;
        }

        public static bool TestID(string id)
        {
            string BEIDRegex = @"[0-9]{3}\-[0-9]{7}\-[0-9]{2}";
            Match regexMatch = Regex.Match(id, BEIDRegex);

            if (regexMatch.Success)
            {
                return true;
            }
            return false;
        }

        public static bool TestLeeftijd(int leeftijd)
        {
            return (leeftijd >=0)? true : false;
        }

        public string ID
        {
            get { return id; }
            set 
            { 
                if (TestID(value)) id = value;
            }
        }

        public string Naam
        {
            get { return naam; }
            set { this.naam = value; }
        }

        public int Leeftijd
        {
            get { return leeftijd; }
            set 
            { 
                if (TestLeeftijd(value)) leeftijd = value;        
            }
        }
    }
}
