using System;
using System.Data;
using System.Text;
class MarketingFirmDataRecord
{
    static void Main()
    {
        string firstName;
        string familyName;
        byte age;
        char gender;
        string IDnumber;
        uint uniqueEmploymentNumber;

        firstName = "Aleksandar";
        familyName = "Aleksandrov";
        age = 20;
        gender = 'm';
        IDnumber = "0004076633";
        uniqueEmploymentNumber = 27560001;
        Console.WriteLine("{0} {1}\n{2}\n{3}\n{4}\n{5}", firstName, familyName, age, gender, IDnumber, uniqueEmploymentNumber);
    }
}