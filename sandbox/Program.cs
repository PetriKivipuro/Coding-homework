using System;
using System.Collections.Generic;

namespace sandbox
{
    class Program
    {

        public static void Main(string[] args)
        {
            ReadNumber();
        }

        public static int ReadNumber()
        {
            while (true)
            {
                Console.Write("Give a number: ");
                try
                {
                    int readNumber = Convert.ToInt32(Console.ReadLine());
                    return readNumber;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}