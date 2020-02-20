using System;

namespace exercise_100
{
    class Debt
    {
        private double balance;
        private double interestRate;


        public Debt(double initialBalance, double initialInterestRate)
        {
            this.balance = initialBalance;
            this.interestRate = initialInterestRate;
        }

        public void PrintBalance()
        {
            Console.WriteLine(this.balance);
        }
        public void WaitOneYear()
        {
            double balanceAfetryr = (this.balance * this.interestRate);

            Console.WriteLine(balanceAfetryr);
        }

    }
}