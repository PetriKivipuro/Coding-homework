using System;
using System.Collections.Generic;

namespace exercise_110
{
    class Program
    {
<<<<<<< HEAD
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<Item> items = new List<Item>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "")
                {
                    break;
                }
                items.Add(new Item(name));

            }
            foreach (Item item in items)
            {
                Console.WriteLine("Name: ");
                Console.WriteLine(item);
            }

        }

=======
      // IMPLEMENT YOUR CODE IN HERE!
      List<Item> items = new List<Item>();

      while (true)
      {
        // ohjelma pyytää ekaksi Name:
        // sen perään käyttäjä antaa inputin
        Console.Write("Name: ");
        string input = Console.ReadLine();
        // jos input on tyhjä -- ohjelma lopettaa
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
>>>>>>> c3fead5f94dfd706c08361e434c9cbdec85bffe9
    }
}






