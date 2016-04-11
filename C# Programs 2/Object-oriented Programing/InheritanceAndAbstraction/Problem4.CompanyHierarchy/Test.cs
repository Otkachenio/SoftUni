using System;

namespace Problem4.CompanyHierarchy
{
    class Test
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(36574, "John", "Doe", 1500, Departament.Sales);
            SalesEmployee peshe = new SalesEmployee(45821, "Peshe", "Getish", 1200, Departament.Sales);

            Sales sale = new Sales("Candy App", DateTime.Today, 1000);
            peshe.Sale(sale);
            Sales sale2 = new Sales("Cola App", DateTime.Today, 800);
            peshe.Sale(sale2);

            Sales avira = new Sales("Avira", DateTime.Today, 10000);
            peshe.Sale(avira);

            Manager alex = new Manager(77777, "Aleksandar", "Aleksandrov");
            alex.AddEmployee(peshe);
            alex.AddEmployee(emp);

            Console.WriteLine(alex);
        }
    }
}
