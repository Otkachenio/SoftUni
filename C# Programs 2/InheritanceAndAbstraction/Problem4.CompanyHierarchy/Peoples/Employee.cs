using System;

namespace Problem4.CompanyHierarchy
{
    public enum Departament { Production, Accounting, Sales, Marketing };

    class Employee : Person, IEmployee
    {
        private decimal salary;
        private Departament departament;

        public Employee(
            int id, string firstName, string lastName, decimal salary, Departament departament) :
            base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.departament = departament;
        }

        public decimal Salary
        {
            get { return this.salary; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative number!");
                }

                this.salary = value;
            }
        }

        public Departament Departament
        {
            get { return this.departament; }
            
            set
            {
                this.departament = value;
            }        
        }

        public override string ToString()
        {
            string result = string.Format("{0} {1} - ID: {2} - Salary: {3}, Departament: {4}",
                FirstName, LastName, ID, this.salary, this.departament);

            return result;
        }
    }
}
