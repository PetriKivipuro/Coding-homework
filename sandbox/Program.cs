using System;
using System.Collections.Generic;
using System.IO;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime start3 = DateTime.Now;
            Book senseAndSensibility = new Book("Sense and Sensibitilty", 1811, "All begins from ");
            Book prideAndPredujice = new Book("Pride and Prejudice", 1813, "This is a story of a duck");

            Dictionary<string, Book> directory = new Dictionary<string, Book>();
            directory.Add(senseAndSensibility.name, senseAndSensibility);
            directory.Add(prideAndPredujice.name, prideAndPredujice);

            DateTime start2 = DateTime.Now;

            if (directory.ContainsKey("Persuation"))
            {
                Console.WriteLine(directory["Persuasion"]);
            }
            else
            {
                Console.WriteLine("Book not found");
            }
            Console.WriteLine("---------------------------------------");

            if (directory.ContainsKey("Pride and Prejudice"))
            {
                Console.WriteLine(directory["Pride and Prejudice"]);
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
            DateTime end2 = DateTime.Now;
            Console.WriteLine("Aikaa kulunut: " + (end2.Ticks - start2.Ticks) / 10000.0 + " milliseconds");


            Console.WriteLine("--------------<<<>>>--------------------");

            List<Book> books = new List<Book>();

            Book senseAndSensibility2 = new Book("Senssit ja järki", 1600, "tämä on tämä ensimmäinen");
            Book prideAndPredujice2 = new Book("Prinssit ja ennakot", 1854, "Toinen kirja vaikka onkin neljäs");

            books.Add(senseAndSensibility2);
            books.Add(prideAndPredujice2);

            DateTime start = DateTime.Now;

            foreach (Book book in books)
            {
                if (book.name == "Persuation")
                {
                    Console.WriteLine(book);
                    break;
                }
                Console.WriteLine();

                foreach (Book book2 in books)
                {
                    if (book2.name == "Senssit ja järki")
                    {
                        Console.WriteLine(book2);
                        break;
                    }
                }
            }
            DateTime end = DateTime.Now;
            Console.WriteLine("Aikaa kulunut: " + (end.Ticks - start.Ticks) / 10000.0 + " milliseconds");


            Console.WriteLine("--------------<<<>>>--------------------");
            Console.WriteLine("--------------<<<>>>--------------------");

            Book senseAndSensibility3 = new Book("Sense and Sensibility", 1811, "Tämä on nyt kolmas kerta kun käytetään samoja kirjoja");
            Book prideAndPredujice3 = new Book("Pride and Prejudice", 1813, "Neljäs kerta toden sanoo ja reeni jatkuu");

            DateTime start4 = DateTime.Now;

            Library library = new Library();
            library.AddBook(senseAndSensibility3);
            library.AddBook(prideAndPredujice3);

            Console.WriteLine(library.GetBook("pride and prejudice"));
            Console.WriteLine();

            Console.WriteLine(library.GetBook("PRIDE AND PREJUDICE"));
            Console.WriteLine();

            Console.WriteLine(library.GetBooksByPart("SENSE"));

            DateTime end4 = DateTime.Now;

            Console.WriteLine("Aikaa kulunut: " + (end4.Ticks - start4.Ticks) / 10000.0 + " millisekuntia");

            DateTime end3 = DateTime.Now;
            Console.WriteLine("Aikaa kulunut koko hommaan: " + (end3.Ticks - start3.Ticks) / 10000.0 + " milliseconds");

            Console.WriteLine("--------------<<<>>>--------------------");
            Console.WriteLine("--------------<<<>>>--------------------");



        }

    }
}
