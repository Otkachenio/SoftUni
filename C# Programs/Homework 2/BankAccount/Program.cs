using System;
class BankAccount
{
    static void Main()
    {
        string firstName;
        string middleName;
        string lastName;
        decimal balance;
        string bankName;
        string IBAN;
        string BICcode;
        long creditcardnumber1;
        long creditcardnumber2;
        long creditcardnumber3;
        firstName = "Aleksandar";
        middleName = "Emilov";
        lastName = "Aleksandrov";
        balance = 1000000000m;
        bankName = "CCB";
        IBAN = "07KACH3N1OPR0F3S0R";
        BICcode = "CCBBGPK666";
        creditcardnumber1 = 123456789101;
        creditcardnumber2 = 101987654321;
        creditcardnumber3 = 012345678999;
        Console.WriteLine("{0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Balance: {0}", balance);
        Console.WriteLine("BankName: {0}", bankName);
        Console.WriteLine("IBAN: {0} \nBIC code: {1}", IBAN, BICcode);
        Console.WriteLine("Credit Card Number: {0} \nCredit Card Number: {1} \nCredit Card Number: {2}", creditcardnumber1, creditcardnumber2, creditcardnumber3);
        Console.ReadLine();
    }
}