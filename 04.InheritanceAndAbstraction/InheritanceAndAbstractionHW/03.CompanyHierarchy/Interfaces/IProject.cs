using System;
using _03.CompanyHierarchy.Enums;

namespace _03.CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string ProjectName { get; }
        DateTime ProjectStartDate { get; }
        string Details { get; }
        State State { get; }
        void CloseProject();
    }
}
