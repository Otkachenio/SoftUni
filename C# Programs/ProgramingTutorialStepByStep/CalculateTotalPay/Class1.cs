using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTotalPay
{
    class TestEmployee
    {
        static void Main()
        {
            Employee alex = new Employee();
            Employee lynda = new Employee();

            alex.salary = 90000;
            alex.bonus = 20000;
            alex.CalculateTotalThePay();

            lynda.salary = 100000;
            lynda.bonus = 20000;
            lynda.CalculateTotalThePay();
        }
    }
}
