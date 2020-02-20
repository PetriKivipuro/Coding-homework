using System;

namespace exercise_100
{
    class Program
    {
        public static void Main(string[] args)
        {
            Debt mortgage = new Debt(120000.0, 1.01);

            mortgage.PrintBalance();
            mortgage.WaitOneYear();

            int year = 0;
            while (year < 20)
            {


                mortgage.WaitOneYear();
                year = year + 1;

            }
            mortgage.PrintBalance();

        }
    }
}



