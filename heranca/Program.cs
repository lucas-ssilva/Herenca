using System;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //upcasting
            Account acc1 = new BusinessAccount(1011, "Alex", 0.0, 200.0);
            Account acc2 = new SavingsAccount(200.00, 1011,"Alex", 0.0, 100.0);

            //downcasting

            BusinessAccount acc3 = (BusinessAccount)acc1; //conversão
            BusinessAccount acc6 = acc1 as BusinessAccount; //conversão
            //BusinessAccount acc4 = (BusinessAccount)acc2; // vai dar erro, não da pra conversar savings em business

            if (acc2 is BusinessAccount)
            {
                BusinessAccount acc4 = (BusinessAccount)acc2;
            }
            
            if (acc2 is SavingsAccount)
            {
                SavingsAccount acc4 = (SavingsAccount)acc2;
                acc4.UpdateBalance();
                Console.WriteLine("Update");
            }

            Account acc7 = new BusinessAccount(101, "Alex", 500.0, 0.01);
            Account acc8 = new SavingsAccount(100.0, 1101, "Anna", 500.0,0.01);

            acc7.Withdraw(10.0); //sobreposição 
            acc8.Withdraw(10.0); //sobreposição 

            Console.WriteLine(acc7.Balance);
            Console.WriteLine(acc8.Balance);

            acc7.Deposit(10.0);
            acc8.Deposit(10.0);

            Console.WriteLine(acc7.Balance);
            Console.WriteLine(acc8.Balance);

        }
    }
}
