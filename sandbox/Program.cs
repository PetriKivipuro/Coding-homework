using System;
using person;


namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teacher first = new Teacher();
            // Teacher second = new Teacher();
            // Teacher third = new Teacher();

            // double average = (first.Grade() + second.Grade() + third.Grade()) / 3.0;

            // Console.WriteLine("Grading average " + average);


            int hiiri = 5;
            int keyboard = 10;

            int tuotteidenHinta = Calc(hiiri, keyboard);
            int postikulut = 10;

            int total = Calc(tuotteidenHinta, postikulut);

            // System.Console.WriteLine(total); //25


            Calc(2, 2, 2);
        }
        private static int Calc(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        private static void Calc(int a, int b, int c)
        {
            int sum = a + b + c;
            int sum2 = Calc(3, 3);
            int total = sum + sum2;
            System.Console.WriteLine(total.ToString());
        }
    }
}

