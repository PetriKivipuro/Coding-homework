using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<TelevisionProgram> tvprog = new List<TelevisionProgram>();

      while (true)
      {
        Console.Write("Name: ");
        string movieName = Console.ReadLine();

        if (movieName == "")
        {
          break;
        }
        Console.Write("Duration: ");
        int duration = Convert.ToInt32(Console.ReadLine());

        tvprog.Add(new TelevisionProgram(movieName, duration));
      }
      Console.WriteLine();
      Console.Write("Program's maximum duration? ");
      int maxLenght = Convert.ToInt32(Console.ReadLine());


      foreach (TelevisionProgram prog in tvprog)
        if (prog.duration <= maxLenght) // pienempi TAIYHTÄSUUURI!!!!!!!!
        {
          Console.WriteLine(prog);
        }
    }
  }
}





