using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      // Remember also to create the file Book.cs and class in it!
      List<Book> books = new List<Book>();

      while (true)
      {
        Console.Write("Name: ");
        string theTitle = Console.ReadLine();
        if (theTitle == "")
        {
          break;
        }
        Console.Write("Pages: ");
        int numberOfPages = Convert.ToInt32(Console.ReadLine());

        Console.Write("Publication year: ");
        int publicationYear = Convert.ToInt32(Console.ReadLine());


        books.Add(new Book(theTitle, numberOfPages, publicationYear));
      }

      Console.WriteLine();
      Console.Write("What information will be printed? ");
      string printed = Console.ReadLine();


      foreach (Book item in books)
      {
        if (printed == "everything")
        {
          Console.WriteLine(item.title + ", " + item.pages + " pages, " + item.yearOfPublication);
        }

        if (printed == "title")
        {
          Console.WriteLine(item.title);
        }


      }
    }
  }
}




