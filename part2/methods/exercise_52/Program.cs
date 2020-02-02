using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintFromNumberToOne(3);
    }

    // Write your method here:

    public static void PrintFromNumberToOne(int number)
    {
      int i = 1;
      while (i <= number)
      {
        Console.WriteLine(number);
        number--;
      }
    }


  }
}
