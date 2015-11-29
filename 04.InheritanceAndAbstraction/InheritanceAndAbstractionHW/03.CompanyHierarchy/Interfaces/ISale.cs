using System;

namespace _03.CompanyHierarchy.Interfaces
{
    public interface ISale
    {
        string ProductName { get; }
        DateTime Date { get; }
        double Price { get; }
    }
}
