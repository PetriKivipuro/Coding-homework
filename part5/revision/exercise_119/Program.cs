using System;
using System.IO;


namespace exercise_119
{
  class Program
  {
    public static void Main(string[] args)
    {
      Timer timer = new Timer();
      while (true)
      {
        Console.WriteLine(timer);
        timer.Advance();
        // TRY - CATCH ?????
        // try
        // {
        //   System.Threading.Thread.Sleep(10);
        // }
        // catch (Exception e)
        // {
        //   Console.WriteLine("ERror happened: +" + e);
        // }

      }
    }
  }
}
