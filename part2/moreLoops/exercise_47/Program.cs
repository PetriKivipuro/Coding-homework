using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
            //tämä on epäselvää
      
      Console.WriteLine("Where to?");
      int to = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int from = Convert.ToInt32(Console.ReadLine());


      for (int k = from; k <= to; k++)
      {
        if (k < from)
        {
          continue;
        }
        else
        {
            Console.WriteLine(k);
        }
      }
      
        
          
         
      
    }
  }
}
