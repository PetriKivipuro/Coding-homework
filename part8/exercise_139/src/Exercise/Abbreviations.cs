using System.Collections.Generic;

namespace Exercise
{
    public class Abbreviations
    {
        private Dictionary<string, string> kirjasto;
        public void AddAbbreviation(string abbreviation, string explanation)
        {
            this.kirjasto = new Dictionary<string, string>();
        }

        public bool HasAbbreviation(string abbreviation)
        {
            return false;
        }

        public string FindExplanationFor(string abbreviation)
        {
            return null;
        }
    }
}