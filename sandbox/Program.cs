using System;
using System.Collections.Generic;



namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {

            Engine moottori = new Engine("bensa", "miksi tyhjä", "Pösö", "Pesöö 3L 99-01");

            Console.WriteLine(moottori.engineType);
            Console.WriteLine(moottori.identifier);
            Console.WriteLine(moottori.manufacturer);
            Console.WriteLine(moottori.description);


        }
    }
}