using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int sum = 0;
      while (true)
      {
        Console.WriteLine("Give a number:");
        int something = Convert.ToInt32(Console.ReadLine());
        
          if (something != 0)
          
        {
          sum = sum + something;
        }
                   
          if (something == 0)
        {
          Console.WriteLine("Total sum of numbers: " + sum);
          break;
        }
          
        
                    
      }
    }
  }
}
