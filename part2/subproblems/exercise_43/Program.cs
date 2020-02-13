using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int user = Convert.ToInt32(Console.ReadLine());

      if (user < 0)
      {
        Console.WriteLine(user * (-1));
      }
      
      else if (user >= 0)
      {
        Console.WriteLine(user);
      }
    }
  }
}
