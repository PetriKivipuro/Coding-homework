using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first number!");
      int numb = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Give the second number!");
      int numb2 = Convert.ToInt32(Console.ReadLine());

      if (numb < numb2)
      {
        Console.WriteLine("The larger number is " + numb2 + "!");
      }
      
      else if (numb > numb2)
      {
        Console.WriteLine("The larger number is " + numb + "!");
      }

      else if (numb == numb2)
      {
        Console.WriteLine("They are equal!");
      }
    }
  }
}
