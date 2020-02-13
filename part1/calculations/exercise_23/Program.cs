using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      int first = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Give the second number!");
      int second = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine(first + " + " + second + " = " + (first + second));
      Console.WriteLine(first + " - " + second + " = " + (first - second));
      Console.WriteLine(first + " * " + second + " = " + (first * second));
      Console.WriteLine(first + " / " + second + " = " + ((double)first / second));




    }
  }
}
