using System;
using System.Collections.Generic;
using System.IO;



namespace sandbox
{
  class Program
  {
    static void Main(string[] args)
    {
      Person paul = new Person("Paul", 24);
      Person ada = new Person("Ada");

      Console.WriteLine(paul);
      Console.WriteLine(ada);
      Console.WriteLine("*************************");
      Console.WriteLine("*************************");
      paul.GrowOlder();
      Console.WriteLine(paul);
      Console.WriteLine("*********PAUL vanhenee yhdellä****************");
      ada.GrowOlder();
      Console.WriteLine(ada);


      Console.WriteLine("**********ADA vanhenee yhdellä***************");
      Console.WriteLine("**********PAUL vanhenee 15 ***************");
      paul.GrowOlder(15);
      Console.WriteLine(paul);



    }
  }
}



