namespace Exercise3
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account(0, 10000);
            account.Deposit(20000);
            account.Withdraw(10000);
            account.Withdraw(10000);
            
            Console.ReadLine();

        }
    }
}
