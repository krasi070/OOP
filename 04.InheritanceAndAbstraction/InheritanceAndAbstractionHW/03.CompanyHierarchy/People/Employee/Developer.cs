using System;
using System.Collections.Generic;
using _03.CompanyHierarchy.SalesAndProjects;
using _03.CompanyHierarchy.Enums;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.People.Employee
{
    public class Developer : RegularEmployee, IDeveloper
    {
        private HashSet<Project> set;

        public Developer(int id, string firstName, string lastName, double salary, params Project[] projects)
            : base(id, firstName, lastName, salary, Department.Production)
        {
            this.set = new HashSet<Project>();
            this.AddProject(projects);
        }

        public void AddProject(params Project[] projects)
        {
            foreach (var project in projects)
            {
                this.set.Add(project);
            }
        }

        public void RemoveProject(Project project)
        {
            this.set.Remove(project);
        }

        public override string ToString()
        {
            List<string> projectNames = new List<string>();

            foreach (var project in this.set)
            {
                projectNames.Add(project.ProjectName);
            }

            return base.ToString() + string.Format("\nProjects: {0}", string.Join(", ", projectNames));
        }
    }
}
