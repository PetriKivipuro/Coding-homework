using System;
using System.Collections.Generic;

namespace exercise_80
{
  class Program
  {
    public static void Main(string[] args)
    {
      int[] numbers = { 5, 1, 3, 4, 2 }; // luotu array--ryhmä
      int sum = SumOfNumbersInArray(numbers); // annettu sum nimi "SONIA" metodille (SumOfNumbersInArray)
      Console.WriteLine(sum); // tulostaa sum, joka sisältää methodin "SONIA" 

    }

    public static int SumOfNumbersInArray(int[] numbers) // boxi metodille ja se nimettu SumOfNumbersInArray "SONIA".
    {
      //metodin sisällä suoritettava toiminto, joka lähetetään takaisin Mainiin.

      int methodSum = 0;
      foreach (int number in numbers)
      {
        methodSum = methodSum + number;
      }
      return methodSum;
    }
  }
}


