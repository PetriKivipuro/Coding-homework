using System;
using System.IO;

namespace exercise_117
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Ask the user for the file name and print the content of the file
      while (true)
      {
        Console.WriteLine("Which file should have its contents printed?");
        string content = Console.ReadLine();
        /*
        -- string file = File. ReadAllText(content);
        -- Console. WriteLine(file);
      JOS  käyttää näitä niin while looppia ja if komentoa ei tarvii
     on itseasiassa parempi ja yksinkertaisempi niin
    */


        if (content.Contains(content))
        {
          string text = File.ReadAllText(content);
          Console.WriteLine(text);
          break;
        }
      }

    }

  }
}
