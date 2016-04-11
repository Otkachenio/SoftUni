using System;
using System.Collections.Generic;

namespace Problem4.CompanyHierarchy
{
    class Developer : Employee
    {
        List<Project> projectsList = new List<Project>();

        public Developer(int id, string firstName, string lastName,
            decimal salary, Departament departament
            ) : base (id, firstName, lastName, salary, departament) { }

        public void AddProject(Project project)
        {
            this.projectsList.Add(project);
        }
    }
}