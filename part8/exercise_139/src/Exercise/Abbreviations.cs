using System.Collections.Generic;

namespace Exercise
{
    public class Abbreviations
    {
        private Dictionary<string, string> abbreviations;

        public Abbreviations()
        {
            this.abbreviations = new Dictionary<string, string>();
        }

        public void AddAbbreviation(string abbreviation, string explanation)
        {
            this.abbreviations.Add(abbreviation, explanation);
        }

        public bool HasAbbreviation(string abbreviation)
        {
            if (this.abbreviations.ContainsKey(abbreviation))
            {
                return true;
            }
            return false;
        }


        public string FindExplanationFor(string abbreviation)
        {
            if (HasAbbreviation(abbreviation))
            {
                return this.abbreviations[abbreviation];
            }
            return "not found";
        }
    }
}