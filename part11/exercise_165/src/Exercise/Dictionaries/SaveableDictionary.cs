namespace Exercise
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    public class SaveableDictionary
    {
        private Dictionary<string, string> sanakirja;
        private string tiedosto;


        public SaveableDictionary()
        {
            this.sanakirja = new Dictionary<string, string>();
        }

        public SaveableDictionary(string file) : this()
        {
            this.tiedosto = file;
        }

        public void Add(string word, string translation)
        {
            if (!this.sanakirja.ContainsKey(word) && !this.sanakirja.ContainsValue(translation))
            {
                this.sanakirja.Add(word, translation);
            }
        }

        public bool Load()
        {
            return false;
        }

        public bool Save()
        {
            return false;
        }

        public string Translate(string word)
        {
            if (sanakirja.ContainsKey(word))
            {
                return this.sanakirja[word];
            }

            foreach (KeyValuePair<string, string> kvp in sanakirja)
            {
                if (kvp.Value == word)
                {
                    return kvp.Key;
                }
            }
            return null;
        }

        public void Delete(string word)
        {
        }
    }
}
