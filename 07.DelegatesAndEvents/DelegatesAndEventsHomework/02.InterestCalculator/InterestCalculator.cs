namespace _02.InterestCalculator
{
    using System;

    public class InterestCalculator
    {
        private double money;
        private double interest;
        private int years;

        public InterestCalculator(double money, double interest, int years, Func<double, double, int, double> func)
        {
            this.Money = money;
            this.Intereset = interest;
            this.Years = years;
            this.CalculatedInterest = CalculateInterest(func);
        }

        public double Money
        {
            get
            {
                return this.money;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public double Intereset
        {
            get
            {
                return this.interest;
            }

            private set
            {
                if (interest < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest cannot be negative");
                }

                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Years cannot be negative");
                }

                this.years = value;
            }
        }

        public double CalculatedInterest { get; private set; }

        private double CalculateInterest(Func<double, double, int, double> func)
        {
            return func(this.Money, this.Intereset, this.Years);
        }
    }
}
