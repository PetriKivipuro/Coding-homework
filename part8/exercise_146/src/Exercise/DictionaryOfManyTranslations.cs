using System.Collections.Generic;

namespace Exercise
{
    public class DictionaryOfManyTranslations
    {
        private Dictionary<string, List<string>> sanakirja;
        public DictionaryOfManyTranslations()
        {
            this.sanakirja = new Dictionary<string, List<string>>();
        }
        public void Add(string word, string translation)
        {
            if (!this.sanakirja.ContainsKey(word))
            {
                this.sanakirja.Add(word, new List<string>());
            }
            List<string> sanakirjaValmis = this.sanakirja[word];
            sanakirjaValmis.Add(translation);
        }

        public List<string> Translate(string word)
        {
            if (!this.sanakirja.ContainsKey(word))
            {
                this.sanakirja.Add(word, new List<string>());
            }
            return this.sanakirja[word];
        }

        public void Remove(string word)
        {
            this.sanakirja.Remove(word);
        }
    }
}