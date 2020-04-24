using System;

namespace sandbox
{
    public class Printer
    {
        public void Print(IReadable readable)
        {
            Console.WriteLine(readable.Read());
        }
    }
}