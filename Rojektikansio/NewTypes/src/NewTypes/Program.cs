using System;
using Pets;

namespace ConsoleAplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog doggie = new Dog();
            Cat cattie = new Cat();

            Console.WriteLine(doggie.TalkToOwner());
            Console.WriteLine(cattie.TalkToOwner());

        }
    }
}