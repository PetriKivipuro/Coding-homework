using System;
using System.Collections.Generic;

namespace extra_03
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("How many numbers?");
      int amount = Convert.ToInt32(Console.ReadLine());

      int maara = 0;
      int sum = 0;

      Console.WriteLine("Give " + amount + " numbers:");

      {
        int input = Convert.ToInt32(Console.ReadLine());

        if (amount < 0)
        {
          maara++;
        }

      }
      sum += maara;

      Console.WriteLine(sum);
    }
  }
}
