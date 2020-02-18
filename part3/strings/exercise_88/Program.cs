using System;
using System.Collections.Generic;

namespace exercise_88
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string story = Console.ReadLine();
                string[] lines = story.Split(" ");

                if (story == "")
                {
                    break;
                }

                for (int i = 0; i < lines.Length;)
                {
                    Console.WriteLine(lines[0]);
                    break;
                }

            }
        }
    }
}




