using System;
using System.Collections.Generic;

namespace exercise_73
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                list.Add(input);

            }
            //Tämä olisi kiva tietää for -lausekkeen muodossa!!!
            int sum = 0;
            foreach (int number in list)
            {
                sum = sum + number;
            }
            Console.WriteLine("Sum: " + sum);
        }

    }
}









