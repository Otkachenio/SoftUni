using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheTax_MyWay
{
    class Program
    {
        static void Main()
        {
            decimal tax;
            decimal salary;
            Console.Write("Please, enter your salary: ");
            bool check = decimal.TryParse(Console.ReadLine(), out salary);
            if (check)
            {
                if (salary <= 8350)
                {
                    tax = (salary * .10m);
                    Console.WriteLine("Your taxes are: " + tax);
                }
                else if (salary <= 33950)
                {
                    tax = (8350 * .10m) + ((salary - 8350) * .15m);
                    Console.WriteLine("Your taxes are: " + tax);
                }
                else
                {
                    tax = (8350 * .10m) + ((33950 - 8350) * .15m) + ((salary - 33950) * .25m);
                    Console.WriteLine("Your taxes are: " + tax);
                }
            }
            else
            {
                Console.WriteLine("Not a valid Entry!");
            }
        }
    }
}

