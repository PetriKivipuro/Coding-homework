using System;

namespace exercise_99
{
    class Program
    {
        public static void Main(string[] args)
        {

            DecreasingCounter counter = new DecreasingCounter(20);
            counter.PrintValue();

            counter.Decrement();
            counter.PrintValue();
            counter.Decrement();


            counter.Reset();
            counter.PrintValue();


        }
    }
}



