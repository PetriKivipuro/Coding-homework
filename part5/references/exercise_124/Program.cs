using System;

namespace exercise_124
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Implement your program here!
      //piti luoda uusi class Person


      Person matt = new Person("mattthew");
      matt = null;

      Console.WriteLine(matt);
      matt.GrowOlder();

    }
  }

}
