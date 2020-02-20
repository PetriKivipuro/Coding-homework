using System;

namespace exercise_98
{

    class Product
    {
        private double price;
        private int quantity;
        private string name;

        public Product(string name, double price, int quantity)
        {
            this.price = price;
            this.quantity = quantity;
            this.name = name;
        }
        public void PrintProduct()
        {
            Console.WriteLine(this.name + ": price " + this.price + ": " + this.quantity + " pcs");
        }
    }
}