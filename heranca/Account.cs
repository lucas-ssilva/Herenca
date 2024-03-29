﻿using System;
using System.Collections.Generic;
using System.Text;

namespace heranca
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public Account() { }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
       }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }
    }



}
