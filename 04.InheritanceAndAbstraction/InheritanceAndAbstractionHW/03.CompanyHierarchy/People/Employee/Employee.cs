using System;
using _03.CompanyHierarchy.Enums;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.People.Employee
{
    public abstract class Employee : Person, IEmployee
    {
        private double salary;
        private Department department;

        public Employee(int id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public double Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be less than 0");
                }

                this.salary = value;
            }
        }

        public Department Department { get; private set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nSalary: {0:F2}\nDepartment: {1}",
                this.Salary, this.Department);
        }
    }
}



