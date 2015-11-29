using System;
using _03.CompanyHierarchy.SalesAndProjects;

namespace _03.CompanyHierarchy.Interfaces
{
    public interface ISalesEmployee
    {
        void AddSales(params Sale[] sales);
        void RemoveSale(Sale sale);
    }
}
