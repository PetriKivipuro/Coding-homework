using System;
using System.Collections.Generic;

namespace exercise_66
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                list.Add(input);

                int index = list.Count - 1;

                while (index >= 0)
                {
                    string rivit = list[index];
                    Console.WriteLine(rivit);
                    index -= 1;
                }


            }



            /*for (int index = 0; index < list.Count; index++)
            {

                string lista = list[index];
                Console.WriteLine(lista);
            }*/




        }
    }
}
