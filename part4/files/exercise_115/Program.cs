using System;
using System.Collections.Generic;


namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string numbers = Console.ReadLine();

        if (numbers == "end")
        {
          break;
        }
        int sentence = Convert.ToInt32(numbers);

        Console.WriteLine(sentence * sentence * sentence);
      }
    }
  }
}
