namespace _02.BankOfKurtovoKonare.Accounts
{
    using System;
    using Enums;

    public class MortgageAccount : BasicAccount
    {
        public MortgageAccount(CustomerType customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {
 
        }

        public override double CalculateInterest(int months)
        {
            double interest;

            if (this.Customer == CustomerType.Company)
            {
                interest = this.Balance * (1 + (this.InterestRate / 2) * Math.Min(12, months) + 
                    this.InterestRate * Math.Max(0, months - 12));
            }
            else
            {
                interest = this.Balance *= (1 + this.InterestRate * (months > 6 ? months - 6 : 0));
            }

            return interest;
        }
    }
}
