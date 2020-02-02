using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int yksi = Convert.ToInt32(Console.ReadLine());
      int kaksi = Convert.ToInt32(Console.ReadLine());

      if (yksi > kaksi)
      {
        Console.WriteLine(yksi + " is greater than " + kaksi + ".");
      }

      else if (yksi < kaksi)
      {
        Console.WriteLine(yksi + " is less than " + kaksi + ".");
      }

      else if (yksi == kaksi)
      {
        Console.WriteLine(yksi + " is equal to " + kaksi + ".");
      }

    }
  }
}
