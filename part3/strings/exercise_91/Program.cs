using System;
using System.Collections.Generic;

namespace exercise_91
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> person = new List<string>();
            string namerOfPerson = "nothing";
            int ageOfPerson = 0;



            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] partsOfInputs = input.Split(",");


                if (Convert.ToInt32(partsOfInputs[1]) > ageOfPerson)
                {
                    ageOfPerson = Convert.ToInt32(partsOfInputs[1]);
                    namerOfPerson = partsOfInputs[0];
                }
            }
            Console.WriteLine("Name of the oldest: " + namerOfPerson);
        }
    }
}



