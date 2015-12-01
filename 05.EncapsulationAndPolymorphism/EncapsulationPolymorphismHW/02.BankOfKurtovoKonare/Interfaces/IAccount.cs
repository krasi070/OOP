namespace _02.BankOfKurtovoKonare.Interfaces
{
    using Enums;

    public interface IAccount
    {
        CustomerType Customer { get; }
        double Balance { get; }
        double InterestRate { get; }
        void Deposit(double depositAmount);
        double CalculateInterest(int months);
    }
}
