namespace _02.FractionCalculator
{
    using System;

    public struct Fraction
    {
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("Denominator cannot be 0");
                }

                this.denominator = value;
            }
        }

        public long Numerator { get; set; }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long denominator = f1.Denominator * f2.Denominator;
            long numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;

            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long denominator = f1.Denominator * f2.Denominator;
            long numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;

            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            decimal result = (this.Numerator * 1.0m) / this.Denominator;

            return result + "";
        }
    }
}
