using System;
using System.Collections.Generic;
using System.IO;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> postalCodes = new Dictionary<string, string>();
            postalCodes.Add("00710", "Helsinki");
            postalCodes.Add("68600", "Pietarsaari");
            postalCodes.Add("33720", "Tampere");
            postalCodes.Add("33014", "Tampere");
            postalCodes.Add("99999", null);

            /*      Console.WriteLine("Anna postinumero");
                 string input = Console.ReadLine();

                 if (postalCodes.ContainsKey(input))
                 {
                     Console.WriteLine(postalCodes[input]);
                 }
                 else
                 {
                     Console.WriteLine("Antamaasi postinumeroa " + input + " ei löydy!");
                 } */

            if (!postalCodes.ContainsKey("00710"))
            {
                postalCodes.Add("00710", "Hesa");
            }

            Console.WriteLine(postalCodes["00710"]);

            foreach (KeyValuePair<string, string> kvp in postalCodes)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                kvp.Key, kvp.Value);
            }

        }
    }
}
