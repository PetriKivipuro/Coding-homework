using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your age:"); //give your year of birth!
      int age = Convert.ToInt32(Console.ReadLine());

      if (age < 1900)
      {
        Console.WriteLine("You're old");
      }
      else if (age > 1900)
      {
        
        
      }
    }
  }
}
