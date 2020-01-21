using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me the truth!");
      // Write your code here:
      String truth = "True";
      Console.ReadLine();
      
      bool boolarvo = System.Convert.ToBoolean(truth);
      Console.WriteLine(boolarvo);

      /*truth = "false";
      boolarvo = System.Convert.ToBoolean(truth);
      Console.WriteLine(boolarvo);*/
      

    }
  }
}
