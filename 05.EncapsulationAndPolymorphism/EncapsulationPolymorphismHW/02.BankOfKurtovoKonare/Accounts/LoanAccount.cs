namespace _02.BankOfKurtovoKonare.Accounts
{
    using Enums;

    public class LoanAccount : BasicAccount
    {
        public LoanAccount(CustomerType customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {
 
        }

        public override double CalculateInterest(int months)
        {
            double interest = this.Balance;

            if (this.Customer == CustomerType.Individual && months > 3)
            {
                interest = this.Balance * (1 + this.InterestRate * (months - 3));
            }

            if (this.Customer == CustomerType.Company && months > 2)
            {
                interest = this.Balance * (1 + this.InterestRate * (months - 2));
            }

            return interest;
        }
    }
}
