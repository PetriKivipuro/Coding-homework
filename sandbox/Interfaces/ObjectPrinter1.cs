using System;

namespace sandbox
{
    public class Printer1
    {
        public void Print(IReadable readable)
        {
            Console.WriteLine(readable.Read());
        }
    }
}