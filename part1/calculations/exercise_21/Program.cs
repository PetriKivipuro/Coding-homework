using System;

namespace exercise_21
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

      double average = (first + second) / 2.0;
      Console.WriteLine("The average is " + average);





    }
  }
}
