using System;
using System.Collections.Generic;



namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> postalCodes = new Dictionary<string, string>();
            postalCodes.Add("07100", "Helsinki");
            postalCodes.Add("90014", "Oulu");
            postalCodes.Add("33720", "Tampere");
            postalCodes.Add("33014", null);

            Console.WriteLine(postalCodes["33720"]);

            if (!postalCodes.ContainsKey("07100"))
            {
                postalCodes.Add("07100", "Hesa");
            }

            Dictionary<int, string> hlotns = new Dictionary<int, string>();
            hlotns.Add(291186, "Pete");
            hlotns.Add(060623, "Juki");

            Console.WriteLine(hlotns[291186] + " " + postalCodes["07100"]);

            foreach (KeyValuePair<string, string> kvp in postalCodes)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);

            }

            foreach (KeyValuePair<int, string> kvp in hlotns)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("---------------------------------------------");



            Book senseAndSoOn = new Book("Sense ans soon", 500, "jajajajaj");
            Book prideAndShit = new Book("Pride and Shit", 850, "wolwolwolololoo");

            Library books = new Library();
            books.AddBook(senseAndSoOn);
            books.AddBook(prideAndShit);

            Console.WriteLine(books.GetBook("Sense ans soon"));

            Console.WriteLine(books.GetBook("SENSE ANS SOON"));

            Console.WriteLine(books.GetBook("SENSE"));



        }
    }
}