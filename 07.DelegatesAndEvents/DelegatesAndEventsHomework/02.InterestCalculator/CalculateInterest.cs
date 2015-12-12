namespace _02.InterestCalculator
{
    using System;

    class CalculateInterest
    {
        static void Main()
        {
            InterestCalculator compoundIC = new InterestCalculator(500, 0.056, 10, GetCompoundInterest);
            InterestCalculator simpleIC = new InterestCalculator(2500, 0.072, 15, GetSimpleInterest);

            Console.WriteLine("Compound: {0:F4}\nSimple: {1:F4}",
                compoundIC.CalculatedInterest, simpleIC.CalculatedInterest);
        }

        private static double GetSimpleInterest(double sum, double interest, int years)
        {
            return Math.Round((sum * (1 + interest * years)), 4);
        }

        private static double GetCompoundInterest(double sum, double interest, int years)
        {
            return Math.Round((sum) * Math.Pow(1 + interest / 12, years * 12), 4);
        }
    }
}
