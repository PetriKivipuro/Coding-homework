using System;

namespace extra_02
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give three numbers:");
      int number1 = Convert.ToInt32(Console.ReadLine());
      int number2 = Convert.ToInt32(Console.ReadLine());
      int number3 = Convert.ToInt32(Console.ReadLine());

      if (number1 > number2 && number1 > number3)
      {
        Console.WriteLine("The greatest number is: " + number1);

      }
      if (number2 > number3 && number2 > number1)
      {
        Console.WriteLine("The greatest number is: " + number2);
      }
      if (number3 > number2 && number3 > number2)
      {
        Console.WriteLine("The greatest number is: " + number3);
      }
    }

  }
}

