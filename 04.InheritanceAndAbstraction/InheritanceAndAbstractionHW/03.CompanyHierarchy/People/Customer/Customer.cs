using System;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.People.Customer
{
    public class Customer : Person, ICustomer
    {
        private double netPurchaseAmount;

        public Customer(int id, string firstName, string lastName, double netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public double NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Net purchase amount cannot be less than 0");
                }

                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return "CUSTOMER\n" + base.ToString() + string.Format("\nNet Purchase Amount: {0:F2}", this.NetPurchaseAmount);
        }
    }
}
