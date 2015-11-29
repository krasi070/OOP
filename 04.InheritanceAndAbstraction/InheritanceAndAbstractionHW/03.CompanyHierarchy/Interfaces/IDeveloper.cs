using System;
using _03.CompanyHierarchy.SalesAndProjects;

namespace _03.CompanyHierarchy.Interfaces
{
    public interface IDeveloper
    {
        void AddProject(params Project[] projects);
        void RemoveProject(Project project);
    }
}
