using System;
using _03.CompanyHierarchy.Enums;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.People.Employee
{
    public class RegularEmployee : Employee, IRegularEmployee
    {
        public RegularEmployee(int id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {

        }

        public override string ToString()
        {
            return "REGULAR EMPLOYEE\n" + base.ToString();
        }
    }
}



