using System;
using person;


namespace sandbox
{
  class Program
  {
    static void Main(string[] args)
    {
      Teacher first = new Teacher();
      Teacher second = new Teacher();
      Teacher third = new Teacher();

      double average = (first.Grade() + second.Grade() + third.Grade()) / 3.0;

      Console.WriteLine("Grading average " + average);
    }
  }
}

