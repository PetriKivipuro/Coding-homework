using System;

namespace exercise_22
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

      double average = (first + second + third) / 3.0;
      Console.WriteLine("The average is " + average);


    }
  }
}
