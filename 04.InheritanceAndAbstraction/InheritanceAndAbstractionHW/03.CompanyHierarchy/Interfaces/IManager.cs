using System;
using _03.CompanyHierarchy.People.Employee;

namespace _03.CompanyHierarchy.Interfaces
{
    public interface IManager
    {
        void AddEmployees(params Employee[] employees);
        void RemoveEmployee(Employee employee);
    }
}
