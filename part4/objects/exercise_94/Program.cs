using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account heikinTili = new Account("Heikki's account", 1000);
      Account personalTili = new Account("Personal account", 0);

      heikinTili.Withdrawal(100);
      personalTili.Deposit(100);

      Console.WriteLine(heikinTili.ToString());
      Console.WriteLine(personalTili);

    }
  }
}



