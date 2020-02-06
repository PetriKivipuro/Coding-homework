using System;
using System.Collections.Generic;

namespace exercise_76
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(-1);
            Console.WriteLine(Sum(numbers));

            numbers.Add(5);
            numbers.Add(1);
            Console.WriteLine(Sum(numbers));
        }
        //must return an integer
        public static int Sum(List<int> givenNumber)
        {
            int sum = 0;

            for (int i = 0; i < givenNumber.Count; i++)
            {
                sum = sum + givenNumber[i]; // sum+=numbers[i];
            }
            return sum;
        }

    }
}


