using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account petenTili = new Account("Peten tili", 100);

      petenTili.Deposit(20);

      Console.WriteLine(petenTili.balance);

    }
  }
}



