using System;

namespace exercise_61
{
    class Program
    {
        public static void Main(String[] args)
        {
            //PrintStars(3);
            //PrintSpaces(4);
            //PrintRightTriangle(15);
            ChristmasTree(4);
        }

        public static void PrintStars(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");

        }

        public static void PrintSpaces(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }


        }

        public static void PrintRightTriangle(int size)
        {
            int left = size - 1;
            for (int i = 1; i <= size; i++) //korkeus
            {

                PrintSpaces(left);
                PrintStars(i);
                left--;
            }
        }

        public static void ChristmasTree(int height)
        {
            for (int i = 1; i < height + 1; i++)
            {
                PrintSpaces(height - i);
                PrintStars(2 * i - 1);
            }
            for (int i = 0; i < 2; i++)
            {
                PrintSpaces(height - 2);
                PrintStars(3);
            }




        }
    }
}

