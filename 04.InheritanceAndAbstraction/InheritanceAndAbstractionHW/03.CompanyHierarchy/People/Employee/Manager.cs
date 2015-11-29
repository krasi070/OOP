using System;
using System.Collections.Generic;
using _03.CompanyHierarchy.Enums;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.People.Employee
{
    public class Manager : Employee, IManager
    {
        private HashSet<Employee> set;

        public Manager(int id, string firstName, string lastName, double salary, Department department,
            params Employee[] employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.set = new HashSet<Employee>();
            this.AddEmployees(employees);
        }

        public void AddEmployees(params Employee[] employees)
        {
            foreach (var employee in employees)
            {
                this.set.Add(employee);
            }
        }

        public void RemoveEmployee(Employee employee)
        {
            this.set.Remove(employee);
        }

        public override string ToString()
        {
            List<string> employees = new List<string>();

            foreach (var employee in this.set)
            {
                employees.Add(employee.FirstName + " " + employee.LastName);
            }

            return "MANAGER\n" + base.ToString() + string.Format("\nList of Employees: {0}",
                string.Join(", ", employees));
        }
    }
}



