namespace sandbox
{
    using System;
    using System.Collections.Generic;
    public class Printer
    {
        public void PrintManyTimes(Object obj, int times)
        {
            int i = 0;
            while (i < times)
            {
                Console.WriteLine(obj.ToString());

                i = i + 1;
            }
        }
    }
}