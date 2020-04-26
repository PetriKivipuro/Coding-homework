namespace sandbox
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            Card first = new Card(10, Suit.Heart);

            Console.WriteLine(first);

            if (first.suit == Suit.Spade)
            {
                Console.WriteLine("is a spade");
            }
            else
            {
                Console.WriteLine("is not a spade");
            }

            Card sec = new Card(4, Suit.Spade);

            Console.WriteLine(sec);
            if (sec.suit == Suit.Spade)
            {
                Console.WriteLine("is a spade");
            }
            else
            {
                Console.WriteLine("is not a spade");
            }
        }
    }
}