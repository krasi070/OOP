using System;
using _03.CompanyHierarchy.Enums;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.SalesAndProjects
{
    public class Project : IProject
    {
        private string projectName;

        public Project(string projectName, DateTime projectStartDate, string details, State state)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = state;
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Project name cannot be null");
                }

                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate { get; set; }

        public string Details { get; set; }

        public State State { get; set; }

        public void CloseProject()
        {
            this.State = State.Close;
        }
    }
}



