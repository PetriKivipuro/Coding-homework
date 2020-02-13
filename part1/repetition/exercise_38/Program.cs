using System;

namespace exercise_38
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
        
          if (something < 0)
          
        {
          sum = sum + 1;
        }
                   
          if (something == 0)
        {
          Console.WriteLine("Total amount of negative numbers: " + sum);
          break;
        }
          
        
                    
      }

    }
  }
}
