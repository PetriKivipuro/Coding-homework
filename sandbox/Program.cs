using System;
using System.Collections.Generic;



namespace sandbox
{
    class Program
    {
        static void Main(string[] args)


        {
            Clock clock = new Clock();

            while (true)
            {
                Console.WriteLine(clock);
                clock.Advance();
            }
        }

    }
}