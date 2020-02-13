using System;

namespace exercise_54
{
    class Program
    {
        public static void Main(String[] args)
        {
            // Call your method here:
            DivisibleByThreeInRange(3, 20);
        }

        // Write your method here:
        public static void DivisibleByThreeInRange(int beginning, int end)
        {
            int currentNumb = beginning;

            while (currentNumb <= end)
            {
                if (currentNumb % 3 == 0)
                {
                    Console.WriteLine(currentNumb);
                }
                currentNumb++;

            }

        }
    }
}
