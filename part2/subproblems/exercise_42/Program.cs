using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
    int first = Convert.ToInt32(Console.ReadLine());
    int second = Convert.ToInt32(Console.ReadLine());

    int sum = (first + second);

    double squareRoot = Math.Sqrt(sum);
    Console.WriteLine(squareRoot);
    
    }
  }
}
