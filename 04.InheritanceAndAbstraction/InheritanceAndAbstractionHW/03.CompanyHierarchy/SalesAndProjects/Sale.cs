using System;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.SalesAndProjects
{
    public class Sale : ISale
    {
        private string productName;
        private double price;

        public Sale(string productName, DateTime date, double price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Product name cannot be null");
                }

                this.productName = value;
            }
        }

        public DateTime Date { get; set; }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (price < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be less than 0");
                }

                this.price = value;
            }
        }
    }
}



