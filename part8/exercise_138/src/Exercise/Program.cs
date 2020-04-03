using System;
using System.Collections.Generic;

namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Do something here

            Dictionary<string, string> nicknames = new Dictionary<string, string>();

            nicknames.Add("matthew", "matt");
            nicknames.Add("michael", "mix");
            nicknames.Add("arthur", "artie");

            nicknames.ContainsKey("");

            foreach (KeyValuePair<string, string> kvp in nicknames)
            {
                Console.WriteLine("{0}'s nickname is {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
