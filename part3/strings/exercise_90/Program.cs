using System;
using System.Collections.Generic;

namespace exercise_90
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> person = new List<string>();
            int oldest = 0;
            while (true)
            {
                string question = Console.ReadLine();

                if (question == "")
                {
                    break;
                }
                //DEbug 
                //Console.WriteLine("------" + question);

                string[] parts = question.Split(",");
                //debugg 
                //Console.WriteLine("------" + parts[0]);
                //Console.WriteLine("------" + parts[1]);
                if (Convert.ToInt32(parts[1]) > oldest)
                {
                    oldest = Convert.ToInt32(parts[1]);
                }
            }
            Console.WriteLine("Age of the oldest: " + oldest);
        }
    }
}
/*
List<string> persons = new List<string>();
            int oldest = 0;
            while (true)
            {
                string asked = Console.ReadLine();
                if (asked == "")
                {
                    break;
                }
                //DEbug Console.WriteLine("------" + asked)

                string[] parts = asked.Split(",");
                //DEbug Console.WriteLine("------" + partscd[0])
                //DEbug Console.WriteLine("------" + parts[1])
                //name age
                if (Convert.ToInt32(parts[1]) > oldest)
                {
                    oldest = Convert.ToInt32(parts[1]);
                }

            }
            Console.WriteLine("Age of the oldest: " + oldest);
*/


