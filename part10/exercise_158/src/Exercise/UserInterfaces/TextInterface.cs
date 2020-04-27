namespace Exercise
{
    using System;
    using System.Collections.Generic;
    public class TextInterface
    {
        // Create the userinterface here

        private List<Book> books;
        public TextInterface()
        {
            this.books = new List<Book>();
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Input the name of the book, empty stops: ");
                string nameBook = Console.ReadLine();

                if (nameBook == "")
                {
                    break;
                }
                Console.WriteLine("Input the age recommendation: ");
                string ageReco = Console.ReadLine();

                int age = Convert.ToInt32(ageReco);
                this.books.Add(new Book(nameBook, age));

            }
            Console.WriteLine(this.books.Count + " books in total." + "\n");

            Console.WriteLine("Books:");

            books.Sort();
            foreach (Book kirjaset in this.books)
            {
                Console.WriteLine(kirjaset);
            }

        }
    }
}