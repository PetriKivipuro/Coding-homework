using System;

namespace exercise_109
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
      if (this.balance < 10.60)
      {
        //this.balance = this.balance;
      }
      else
      {
        double i = 10.60;
        this.balance = this.balance - i;
      }
    }


    public void DrinkCoffee()
    {
      if (this.balance < 2.0)
      {
        Console.WriteLine(this.balance);
      }
      else
      {
        // double j = 2.0;
        // this.balance = this.balance - j;
        this.balance = this.balance - 2.0;
      }

    }
    public void AddMoney(double amount)
    {

      // jos amount on suurempi kuin 0
      // ja saldo+amount on pienempi tai yhtäsuuri kuin 150
      // sitten `uusi`saldo on saldon ja amountin summa

      if (amount > 0 && this.balance + amount <= 150)
      {
        this.balance = this.balance + amount;
      }

      //jos saldon ja amountin summa on suurempi kuin 150
      // silloin saldoksi annetaan 150
      // tällä voidaan rajoittaa saldon määrää
      if (this.balance + amount > 150)
      {
        this.balance = 150;
      }


    }
  }
}




