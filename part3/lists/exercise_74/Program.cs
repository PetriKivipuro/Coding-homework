using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);

      }
      Console.WriteLine("Search for?");
      string whoseLost = Console.ReadLine();
      //Console.WriteLine(" --- u gave " + whoseLost); //debugg
      // Debugg  --- Console.WriteLine(list.Contains(whoseLost));

      //Tarkistaa sisältääkö "list" elementin arvolla whoseLost
      if (list.Contains(whoseLost))
      {
        Console.WriteLine(whoseLost + " was found!");
      }
      else //id (!/list.Contains(whoseLost)) Kävisi myös tähän, mutta else on parempi, koska vain kaksi vaihtoehtoa.
      {
        Console.WriteLine(whoseLost + " was not found!");
      }


    }
  }
}

