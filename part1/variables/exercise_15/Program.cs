using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string:");
      string eka = Console.ReadLine();
      
      Console.WriteLine("Give an integer:");
      string number = Console.ReadLine();
      int intValue = Convert.ToInt32(number);
      

      Console.Write("Give a double:");
      string tupla = Console.ReadLine();
      double arvoinen = Convert.ToDouble(tupla);
      
      
      Console.WriteLine("Give a boolean: ");
      string truth = Console.ReadLine();
      bool boolinarvo = System.Convert.ToBoolean(truth);
      
      
      Console.WriteLine("Your string: " + eka);
      Console.WriteLine("Your integer: " + intValue);
      Console.WriteLine("Your double: " + arvoinen);
      Console.WriteLine("Your boolean: " + boolinarvo);

    }
  }
}
