using System;
using System.Collections.Generic;



namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Packer packer = new Packer();

            foreach (IStorable item in packer.GiveAListOfThings())
            {
                Console.WriteLine(item);
            }
        }
    }
}