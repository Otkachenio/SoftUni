using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTotalPay
{
    class Employee
    {
        public double salary, bonus;

        public void CalculateTotalThePay()
        {
            double totalPay = salary + bonus;
            Console.WriteLine("Total Pay: " + totalPay);
        }
    }
}
