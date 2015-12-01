namespace _02.BankOfKurtovoKonare
{
    using System;
    using Interfaces;
    using Accounts;
    using Enums;

    class TestBankSystem
    {
        static void Main()
        {
            IAccount[] accounts = new IAccount[]
            {
                new DepositAccount(CustomerType.Individual, 10000.00, 0.025),
                new LoanAccount(CustomerType.Individual, -1200, 0.005),
                new MortgageAccount(CustomerType.Company, -120000, 0.009),
                new DepositAccount(CustomerType.Company, 100, 0.01),
                new LoanAccount(CustomerType.Company, -10000, 0.0175)
            };

            accounts[0].Deposit(1012.36);
            accounts[4].Deposit(1212.12);

            Console.WriteLine("{0}\nInterest: {1:F2}", accounts[0].ToString(), accounts[0].CalculateInterest(12));
            Console.WriteLine("{0}\nInterest: {1:F2}", accounts[1].ToString(), accounts[1].CalculateInterest(2));
            Console.WriteLine("{0}\nInterest: {1:F2}", accounts[2].ToString(), accounts[2].CalculateInterest(8));
            Console.WriteLine("{0}\nInterest: {1:F2}", accounts[3].ToString(), accounts[3].CalculateInterest(14));
            Console.WriteLine("{0}\nInterest: {1:F2}", accounts[4].ToString(), accounts[4].CalculateInterest(10));
        }
    }
}
