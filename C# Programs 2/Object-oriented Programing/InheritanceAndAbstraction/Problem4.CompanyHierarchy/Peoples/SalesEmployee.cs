using System;
using System.Collections.Generic;

namespace Problem4.CompanyHierarchy
{
    class SalesEmployee : Employee
    {
        private List<Sales> salesList = new List<Sales>();

        public SalesEmployee(int id, string firstName, string lastName,
                                decimal salary, Departament departament
                        ) : base (id, firstName, lastName, salary, departament) { }

        public void Sale(Sales sale)
        {
            this.salesList.Add(sale);
        }

        public override string ToString()
        {
            Console.WriteLine("{0} {1} - ID: {2} - Salary {3}$ - Departament: {4}",
                FirstName, LastName, ID, Salary, Departament);
            Console.WriteLine("Sales: " + salesList.Count);
            foreach (Sales item in salesList)
            {
                Console.WriteLine(item);
            }
            return "";
        }
    }
}
