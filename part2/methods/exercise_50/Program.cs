using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      Console.WriteLine("How many times?");
      int q = Convert.ToInt32(Console.ReadLine());
      PrintPhrase(q);
 
    }
    // Write your method here:
    public static void PrintPhrase(int numbOfTimes) 
    {
      int w = 0;
      while (w < numbOfTimes)
      {
        Console.WriteLine("In a hole in the ground there lived a method");
        w++;
      }
    }
  }
}
