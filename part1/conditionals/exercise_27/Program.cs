﻿using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      int numb = Convert.ToInt32(Console.ReadLine());

      if (numb > 0)
      {
        Console.WriteLine("It is positive");
      }

      else 
      {
        Console.WriteLine("It is not positive");
      }
    

    }
  }
}
