using System;
using System.Collections.Generic;

namespace exercise_114
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string sentence = Console.ReadLine();

        if (sentence == "end")
        {
          break;
        }
        list.Add(sentence);
      }
      int values = list.Count;
      Console.WriteLine(list.Count);
    }
  }
}
