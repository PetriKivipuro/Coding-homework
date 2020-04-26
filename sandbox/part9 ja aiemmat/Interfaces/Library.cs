using System;
using System.Collections.Generic;
namespace sandbox
{
    public class Library
    {
        private Dictionary<string, Book> directory;

        public Library()
        {
            this.directory = new Dictionary<string, Book>();
        }

        public void AddBook(Book book)
        {
            string name = SanitizedString(book.name);

            if (this.directory.ContainsKey(name))
            {
                Console.WriteLine("on jo kirjastossa");
            }
            else
            {
                directory.Add(name, book);
            }
        }

        public Book GetBook(string kijanOtsikko)
        {
            kijanOtsikko = SanitizedString(kijanOtsikko);
            if (this.directory.ContainsKey(kijanOtsikko))
            {
                return this.directory[kijanOtsikko];
            }
            else
            {
                return null;
            }
        }

        public void RemoveBook(string kijanOtsikko)
        {
            kijanOtsikko = SanitizedString(kijanOtsikko);
            if (this.directory.ContainsKey(kijanOtsikko))
            {
                this.directory.Remove(kijanOtsikko);
            }
            else
            {
                Console.WriteLine("Book was not found, cannot be removed!");
            }
        }
        public static string SanitizedString(string input)
        {
            if (input == null)
            {
                return "";
            }
            input = input.ToLower().Trim();
            return input;
        }

        public List<Book> GetBooksByPart(string titlePart)
        {
            List<Book> books = new List<Book>();
            titlePart = SanitizedString(titlePart);
            Dictionary<string, Book>.KeyCollection avvaimet = this.directory.Keys;

            foreach (string kijanOtsikko in avvaimet)
            {
                if (kijanOtsikko.Contains(titlePart))
                {
                    books.Add(this.directory[kijanOtsikko]);
                }
            }
            return books;

        }
    }
}