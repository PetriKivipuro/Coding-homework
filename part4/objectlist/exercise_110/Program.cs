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

    }
}




