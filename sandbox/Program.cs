namespace sandbox
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Random ladyLuck = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = ladyLuck.Next(10);
                Console.WriteLine(randomNumber);

            }
            Console.WriteLine();

            Random saamies = new Random();
            int lampotila = saamies.Next(81) - 30;
            Console.WriteLine(lampotila);


            Random saamies1 = new Random();
            for (int j = 0; j < 10; j++)
            {
                int randomNumber2 = saamies1.Next(81) - 30;
                Console.WriteLine(randomNumber2);

            }
            Console.WriteLine();

            WeatherMan ennuste = new WeatherMan();

            List<string> paivat = new List<string>();
            paivat.Add("Maa");
            paivat.Add("Tii");
            paivat.Add("Kes");
            paivat.Add("Tor");
            paivat.Add("Vappu Per");
            paivat.Add("Lau");
            paivat.Add("Sun");

            Console.WriteLine("vuorokausiennuste: ");

            foreach (string paiva in paivat)
            {
                string saaEnnuste = ennuste.Forecast();
                Console.WriteLine(paiva + ": " + saaEnnuste + ".");
            }




        }
    }
}