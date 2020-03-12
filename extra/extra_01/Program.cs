using System;
using System.Collections.Generic;


namespace extra_01
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("What do you want to print?");

      string sentence = Console.ReadLine();

      Console.WriteLine("How many times you want to print?");
      int amount = Convert.ToInt32(Console.ReadLine());


      for (int i = 0; i < amount; i++)
      {
        Console.WriteLine(sentence);
      }

      /* int i = 0;
       while (i < amount)
       {
         Console. WriteLine(sentence);
         i++;
       } */

    }

  }
}

