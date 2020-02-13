using System;

namespace exercise_18
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
      
      Console.WriteLine("Give the third number!");
      int third = Convert.ToInt32(Console.ReadLine());




      Console.WriteLine("The sum is " + (first + second + third));

    }
  }
}
