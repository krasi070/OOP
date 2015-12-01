namespace _02.BankOfKurtovoKonare.Accounts
{
    using System;
    using Interfaces;
    using Enums;

    public abstract class BasicAccount : IAccount
    {
        private double interestRate;

        protected BasicAccount(CustomerType customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public CustomerType Customer { get; private set; }

        public double Balance { get; protected set; }

        public double InterestRate
        { 
            get { return this.interestRate; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate canot be negative");
                }

                this.interestRate = value;
            }
        }

        public void Deposit(double depositAmount)
        {
            if (depositAmount > 0)
            {
                this.Balance += depositAmount;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Deposit amount cannot be negative");
            }
        }

        public abstract double CalculateInterest(int months);

        public override string ToString()
        {
            return string.Format("Customer Type: {0}\nBalance: {1:F2}\nInterest Rate: {2}",
                this.Customer, this.Balance, this.InterestRate);
        }
    }
}
