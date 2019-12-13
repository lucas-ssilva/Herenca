using System;
using System.Collections.Generic;
using System.Text;

namespace heranca
{
    sealed class SavingsAccount : Account //sealed evita que a classe seja herdada
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(double interestRate, int number, string holder, double balance, double loanLimit) : base(number, holder, balance) 
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {

        }
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public override void Deposit(double amount)
        {
            base.Deposit(amount);
            Balance += 2.0;
        }
    }

}
