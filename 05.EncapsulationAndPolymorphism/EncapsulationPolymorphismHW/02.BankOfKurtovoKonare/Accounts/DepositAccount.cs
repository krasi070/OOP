namespace _02.BankOfKurtovoKonare.Accounts
{
    using System;
    using Enums;

    public class DepositAccount : BasicAccount
    {
        public DepositAccount(CustomerType customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {
 
        }

        public void Withdraw(double withdrawAmount)
        {
            if (withdrawAmount > 0)
            {
                this.Balance -= withdrawAmount;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Withdraw amount cannot be negative");
            }
        }

        public override double CalculateInterest(int months)
        {
            double interest = this.Balance;

            if (this.Balance > 1000)
            {
                interest = this.Balance * (1 + (this.InterestRate * months));
            }

            return interest;
        }
    }
}
