using System;
using System.Collections.Generic;

namespace exercise_134
{
  class Program
  {
    public static void Main(string[] args)
    {

      GradeRegister register = new GradeRegister();
      register.AddGradeBasedOnPoints(93);
      register.AddGradeBasedOnPoints(91);
      register.AddGradeBasedOnPoints(92);

      Console.WriteLine(register.AverageOfPoints());


      UserInterface ui = new UserInterface(register);
      ui.Start();
    }
  }
}
