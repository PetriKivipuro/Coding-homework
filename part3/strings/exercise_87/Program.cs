using System;
using System.Collections.Generic;

namespace exercise_87
{
    class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                string words = Console.ReadLine();
                string[] lines = words.Split(" ");
                if (words == "")
                {
                    break;
                }

                for (int i = 0; i < lines.Length; i++)
                    if (lines[i].Contains("av"))
                    {
                        Console.WriteLine(lines[i]);

                    }




            }
        }

    }

}

