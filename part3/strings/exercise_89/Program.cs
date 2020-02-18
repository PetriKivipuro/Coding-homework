using System;
using System.Collections.Generic;

namespace exercise_89
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string story = Console.ReadLine();
                string[] lines = story.Split(" ");
                //Console.WriteLine("Number of lines: " + lines.Length);

                if (story == "")
                {
                    break;
                }

                for (int i = 0; i < lines.Length;)
                {
                    Console.WriteLine(lines[lines.Length - 1]);
                    break;
                }

            }
        }
    }
}