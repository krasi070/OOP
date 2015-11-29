using System;
using _03.CompanyHierarchy.Enums;

namespace _03.CompanyHierarchy.Interfaces
{
    public interface IEmployee
    {
        double Salary { get; }
        Department Department { get; }
    }
}
