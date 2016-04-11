using System;

namespace Problem4.CompanyHierarchy
{
    public enum State {open, close}

    class Project
    {
        private string projectName;
        private DateTime date;
        private string details;
        private State state;

        public Project(string projectName, DateTime date, string details, State state)
        {
            this.ProjectName = projectName;
            this.Date = date;
            this.Details = details;
            this.state = state;
        }

        public string ProjectName
        {
            get { return this.projectName; }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Project name cannot be less than 2 chars long!");
                }

                this.projectName = value;
            }
        }

        public DateTime Date
        {
            get { return this.date; }

            set
            {
                this.date = value;
            }
        }

        public string Details
        {
            get { return this.details; }

            set
            {
                if (value.Length > 10)
                {
                    throw new ArgumentException("Details must be at least 10 chars long!");
                }

                this.details = value;
            }
        }
    }
}