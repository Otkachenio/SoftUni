using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInfo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter the name of your company: ");
            string companyName = Console.ReadLine();
            Console.Write("Please, enter your company's address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Please, enter your comany's phone number: ");
            string companyPhone = Console.ReadLine();
            Console.Write("Please, enter your comany's fax number: ");
            string companyFax = Console.ReadLine();
            Console.Write("Please, enter your comany's web site: ");
            string companyWeb = Console.ReadLine();
            Console.Write("Please, enter the manager's first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Please, enter the manager's last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Please, enter the manager's age: ");
            string managerAge = Console.ReadLine();
            Console.Write("Please, enter the manager's phone number: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("-------------Company Data-----------------");
            Console.WriteLine("Company name: ".PadRight(20,' ') + " ".PadRight(30, ' ') + companyName);
            Console.WriteLine("Company address: ".PadRight(20, ' ') + " ".PadRight(30, ' ') + companyAddress);
            Console.WriteLine("Company phone number: ".PadRight(20, ' ') + " ".PadRight(30, ' ') + companyPhone);
            Console.WriteLine("Company fax number: ".PadRight(20, ' ') + " ".PadRight(30, ' ') + companyFax);
            Console.WriteLine("Company web site: ".PadRight(20, ' ') + " ".PadRight(30, ' ') + companyWeb);
            Console.WriteLine("Manager's name: ".PadRight(20, ' ') + " ".PadRight(30, ' ') + managerFirstName + " " + managerLastName);
            Console.WriteLine("Manager's age: ".PadRight(20, ' ') + " ".PadRight(30, ' ') + managerAge);
            Console.WriteLine("Manager's phone number: ".PadRight(20, ' ') + " ".PadRight(30, ' ') + managerPhone);
        }
    }
}
