using System;
using System.Collections.Generic;
using System.IO;



namespace sandbox
{
  class Program
  {
    static void Main(string[] args)
    {
      // Clock clock = new Clock();

      // while (true)
      // {
      //   Console.WriteLine(clock);
      //   clock.Advance();
      //   break;
      // }
      // Console.WriteLine();

      // Console.WriteLine("What's your name?");
      // string name = Console.ReadLine();
      // Console.WriteLine("What's your age?");
      // int age = Convert.ToInt32(Console.ReadLine());
      // Console.WriteLine("What's your weight?");
      // double weight = Convert.ToDouble(Console.ReadLine());
      // Console.WriteLine("What's your height?");
      // double height = Convert.ToDouble(Console.ReadLine());

      // Person person = new Person(name, age, weight, height);
      // Console.WriteLine(person);



      Console.WriteLine("***********************");

      Rectanle first = new Rectanle(40, 80);
      Rectanle second = new Rectanle(10, 11);
      Console.WriteLine(first);
      Console.WriteLine(second);

      first.Narrow();
      first.Narrow();
      first.Narrow();
      first.Narrow();
      second.NarrowHeight();
      second.NarrowHeight();
      second.NarrowHeight();
      second.NarrowHeight();
      second.NarrowHeight();
      second.NarrowHeight();
      second.NarrowHeight();
      second.Narrow();
      second.Narrow();
      second.Narrow();
      second.Narrow();
      second.Narrow();

      Console.WriteLine(first);
      Console.WriteLine(first.SurfaceArea());
      Console.WriteLine("*******************************************");
      Console.WriteLine(second);
      Console.WriteLine(second.SurfaceArea());


    }
  }
}



