using System;
using System.Collections.Generic;
using System.IO;



namespace sandbox
{
  class Program
  {
    static void Main(string[] args)
    {
      string text = File.ReadAllText("text.txt");

      Console.WriteLine(" Tehty ReadAllText :lla!");
      Console.WriteLine(text);

      Console.WriteLine("****************************************");
      Console.WriteLine();
      Console.WriteLine("****************************************");

      string[] lines = File.ReadAllLines("text.txt");

      Console.WriteLine(" Tehty ReadAllLines :lla!");

      foreach (string line in lines)
      {
        Console.WriteLine(line);
      }
      Console.WriteLine("****************************************");
      Console.WriteLine();
      Console.WriteLine("****************************************");


      while (true)

      {
        Console.WriteLine("lisää nimi ja ikä. erota ne pilkulla");
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        string[] pieces = input.Split(",");
        Console.WriteLine("nimi: " + pieces[0] + ", age: " + pieces[1]);

      }
      Console.WriteLine("****************************************");
      Console.WriteLine();
      Console.WriteLine("****************************************");

      string[] lines2 = File.ReadAllLines("records.csv");
      foreach (string line in lines2)
      {
        Console.WriteLine("nimi: " + lines2[0] + " age:" + lines2[1]);
      }
      Console.WriteLine("****************************************");
      Console.WriteLine();
      Console.WriteLine("****************************************");


      List<Person> people = new List<Person>();

      string[] lines3 = File.ReadAllLines("records.csv");
      foreach (string line in lines3)
      {
        string[] pieces = line.Split(",");
        string name = pieces[0];
        int age = Convert.ToInt32(pieces[1]);

        people.Add(new Person(name, age));
      }
      Console.WriteLine("Total amount read: " + people.Count);

    }
  }
}

