using System;

namespace exercise_60
{
    class Program
    {
        public static void Main(String[] args)
        {
            // PrintStars(5);
            //PrintStars(3);
            //PrintStars(9);

            // PrintSquare(4);

            //PrintRectangle(17, 3);

            PrintTriangle(4);
        }


        public static void PrintStars(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }

        public static void PrintSquare(int size)
        {

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");

            }
        }
        public static void PrintRectangle(int width, int height)
        {
            for (int i = 0; i < height; i++) //korkeus
            {
                for (int j = 0; j < width; j++) //leveys
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }
        }

        public static void PrintTriangle(int size)
        {
            for (int i = 1; i <= size; i++) //korkeus
            {
                for (int j = 1; j <= i; j++) //leveys
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }

        }
    }
}
