using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      while (true)
      {
        Console.WriteLine("Give a number:");
        int numb1 = Convert.ToInt32(Console.ReadLine());

        if (numb1 == 0)
        {
          break;
        }
        
        else if (numb1 < 0)
        {
          Console.WriteLine("That is negative");
        }

        else if (numb1 > 0)
        {
          Console.WriteLine(Math.Pow(numb1, 2));
        }
      }

    }
  }
}
