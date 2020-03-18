using System;
using System.Collections.Generic;

namespace exercise_110
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<Item> items = new List<Item>();

            while (true)
            {
                // ohjelma pyytää ekaksi Name:
                // sen perään käyttäjä antaa inputin
                Console.Write("Name: ");
                string input = Console.ReadLine();
                // jos input on tyhjä -- ohjelma lopettaaa
                if (input == "")
                {
                    break;
                }
                // jos nimi annetaan se lisätään listaan
                items.Add(new Item(input));
            }
            // kun uusia inputteja eli nimiä ei enää tule
            // ohjelma lisää yhden tyhjän rivin
            Console.WriteLine();
            // ja sen jälkeen luokasta Item haetaan lista items
            // items listalle annetaan nimi i
            // sen jälkeen pyydetään ohjelmaa kirjoittamaan rivi
            // jossa on käytätty i arvoa.
            // i palauttaa mainiin inputnimen sekä ajan jolloin se on luotu
            foreach (Item i in items)
            {
                Console.WriteLine(i);
            }

        }

    }
}
