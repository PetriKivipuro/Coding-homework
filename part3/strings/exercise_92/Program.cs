using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      string firstName = "nothing";
      int longest = 0;
      int highest = 0;

      while (true)
      {
        //Console.WriteLine("anna nimi ja syntymävuosi. Erota ne pilkulla");
        string nameAndYearOfBirth = Console.ReadLine();
        if (nameAndYearOfBirth == "")
        {
          break;
        }
        string[] parts = nameAndYearOfBirth.Split(",");
        int lenght = nameAndYearOfBirth.Length;
        int age = 2020 - Convert.ToInt32(parts[1]);
        if (lenght > longest)
        {
          longest = lenght;
          firstName = parts[0];
        }
        if (age > highest)
        {
          highest = age;
        }
      }
      Console.WriteLine("Longest name: " + firstName);
      Console.WriteLine("Highest age: " + highest);
    }
  }
}



