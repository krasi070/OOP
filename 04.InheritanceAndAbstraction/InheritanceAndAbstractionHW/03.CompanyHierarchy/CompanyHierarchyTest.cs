using System;
using System.Collections.Generic;
using _03.CompanyHierarchy.People.Employee;
using _03.CompanyHierarchy.Enums;
using _03.CompanyHierarchy.People;
using _03.CompanyHierarchy.People.Customer;
using _03.CompanyHierarchy.SalesAndProjects;

namespace _03.CompanyHierarchy
{
    class CompanyHierarchyTest
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            Employee bill = new RegularEmployee(1234, "Bill", "Smith", 10.00, Department.Accounting);
            Person frank = new SalesEmployee(8725, "Frank", "Richardson", 20.00,
                new Sale("Toy", new DateTime(2015, 7, 19), 5.00),
                new Sale("MEGA TOY", new DateTime(2015, 8, 29), 10.00));
            RegularEmployee hank = new RegularEmployee(8456, "Hank", "Tyson", 26.00, Department.Accounting);
            Manager homer = new Manager(8726, "Homer", "James", 50.00, Department.Accounting,
                bill,
                hank);
            Project x = new Project("Project X", new DateTime(2013, 11, 11), "[no details]", State.Open);
            x.CloseProject();
            Developer ivan = new Developer(6545, "Ivan", "Ivanov", 32.00,
                new Project("Flying Car", new DateTime(2014, 1, 24), "[no details]", State.Open),
                x);
            Customer arin = new Customer(7555, "Arin", "Newman", 10000.12);

            people.Add(bill);
            people.Add(frank);
            people.Add(hank);
            people.Add(homer);
            people.Add(ivan);
            people.Add(arin);

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString() + "\n------------------------------------------------------");
            }
        }
    }
}
