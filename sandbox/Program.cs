using System;


namespace sandbox
{
  class Program
  {
    static void Main(string[] args)
    {
      Person pekka = new Person("Pekka");
      Person antti = new Person("Antti");
      int i = 0;
      while (i < 27)
      {
        pekka.GrowOlder();
        i = i + 1;
      }
      antti.GrowOlder();

      if (antti.IsOfLeagalAge())
      {
        Console.WriteLine(antti.name + "täysikänen");
      }
      else
      {
        Console.WriteLine(antti.name + " alaikänen");
      }

      if (pekka.IsOfLeagalAge())
      {
        Console.WriteLine(pekka.name + "täys");
      }
      else
      {
        Console.WriteLine(pekka.name + "alle 18");
      }
    }
  }
}

