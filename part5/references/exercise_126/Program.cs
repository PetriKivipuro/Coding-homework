using System;

namespace exercise_126
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Try your code here, if you want
            PaymentCard petesCard = new PaymentCard(10);

            Console.WriteLine("money " + petesCard.balance);
            bool wasSuccessful = petesCard.TakeMoney(8);
            Console.WriteLine("successfully withdrew: " + wasSuccessful);
            Console.WriteLine("money " + petesCard.balance);

            wasSuccessful = petesCard.TakeMoney(4);
            Console.WriteLine("successfully withdrew: " + wasSuccessful);
            Console.WriteLine("money " + petesCard.balance);

            Console.WriteLine("******************************************");
            PaymentTerminal lunchCafeteria = new PaymentTerminal();

            double change = lunchCafeteria.DrinkCoffee(10);
            Console.WriteLine("remaining change " + change);

            change = lunchCafeteria.DrinkCoffee(5);
            Console.WriteLine("remaining change " + change);

            change = lunchCafeteria.EatLunch(20);
            Console.WriteLine("remaining change " + change);

            Console.WriteLine(lunchCafeteria);

        }
    }
}
