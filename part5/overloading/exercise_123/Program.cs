using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter = new Counter();


      Console.WriteLine(counter.value);
      counter.Decrease(-10);
      Console.WriteLine(counter.value);
      counter.Increase(2000);
      Console.WriteLine(counter.value);
      counter.Decrease(150);
      Console.WriteLine(counter.value + " pitäs olla 1850 (tää on deebuggausta)");


    }
  }
}
