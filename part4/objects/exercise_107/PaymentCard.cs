using System;

namespace exercise_107
{
  public class PaymentCard
  {
    private double balance;

    public PaymentCard(double openingBalance)
    {
      this.balance = openingBalance;
    }

    public override string ToString()
    {
      return "The card has a balance of " + this.balance + " euros";
    }

    public void EatLunch()
    {
      double i = 10.60;
      this.balance = this.balance - i;
    }

    public void DrinkCoffee()
    {
      // double j = 2.0;
      // this.balance = this.balance - j;
      this.balance = this.balance - 2.0;

    }

  }
}



