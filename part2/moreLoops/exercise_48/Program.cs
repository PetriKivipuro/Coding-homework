using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
                
       int sum = 0;
       int validNumb = 0;
       int invalidNumb = 0;
       int even = 0;
       int odd = 0;
      Console.WriteLine("Give numbers:");
      
      while (true)
      {
        
        int something = Convert.ToInt32(Console.ReadLine());
        
          if (something == -1)
        {
          break;
        }
          
          if (something < 0)
        {
          invalidNumb++;          
          continue;
        }
          
        sum += something;
        validNumb++;
        
          if (something % 2 == 0)
        {
          even++;
        }
          else 
        {
          odd++;
        }
      }

      
        Console.WriteLine("Thx! Bye!");
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Numbers: " + (validNumb));
        Console.WriteLine("Average: " + (sum / (double)validNumb));  
        Console.WriteLine("Even: " + even);
        Console.WriteLine("Odd: " + odd);
        
        
    }
  }
}
