using System;
using System.Collections.Generic;

namespace Problem4.CompanyHierarchy
{
    class Manager : Person
    {
        private List<Employee> employeeList = new List<Employee>();

        public Manager(int id, string firstName, string lastName) : 
            base (id, firstName, lastName) { }

        public void AddEmployee(Employee employee)
        {
            this.employeeList.Add(employee);
        }

        public override string ToString()
        {
            Console.WriteLine("*->The Boss: {0} {1} - Lead Manager - ID: {2}<-*",
                FirstName, LastName, ID);
            Console.WriteLine();
            foreach (Employee emp in employeeList)
            {
                Console.WriteLine(emp);
            }

            return "";
        }
    }
}