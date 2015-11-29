using System;
using System.Collections.Generic;
using _03.CompanyHierarchy.Enums;
using _03.CompanyHierarchy.SalesAndProjects;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.People.Employee
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private HashSet<Sale> sales;

        public SalesEmployee(int id, string firstName, string lastName, double salary, params Sale[] sales)
            : base(id, firstName, lastName, salary, Department.Sales)
        {
            this.sales = new HashSet<Sale>();
            this.AddSales(sales);
        }

        public void RemoveSale(Sale sale)
        {
            this.sales.Remove(sale);
        }

        public void AddSales(params Sale[] sales)
        {
            foreach (var sale in sales)
            {
                this.sales.Add(sale);
            }
        }

        public override string ToString()
        {
            List<string> productNames = new List<string>();

            foreach (var sale in this.sales)
            {
                productNames.Add(sale.ProductName);
            }

            return base.ToString() + string.Format("\nSales: {0}", string.Join(", ", productNames));
        }
    }
}



