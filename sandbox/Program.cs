using System;
using System.Collections.Generic;
using System.IO;



namespace sandbox
{
  class Program
  {
    static void Main(string[] args)
    {
      SimpleDate date1 = new SimpleDate(1, 2, 2020);
      SimpleDate date2 = new SimpleDate(1, 2, 2020);
      Console.WriteLine(date1.Equals(date2));
      Console.WriteLine(date1 == date2);

    }
  }
}



