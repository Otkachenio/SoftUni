namespace Problem2.BankOfKurtovoKonare
{
    using System;
    using Problem2.BankOfKurtovoKonare.BankAccounts;
    using Problem2.BankOfKurtovoKonare.Customers;

    class Test
    {
        static void Main(string[] args)
        {
            BankAccount[] accounts =
            {
                new DepositAccount("Ivan", "Ivanov", CustomerType.individuals, 1050, 0.0055m),
                new LoanAccount("Pesho", "Petrov", CustomerType.companies, -10000, 0.0005m),
                new MortgageAccount("Gosho", "Borisov", CustomerType.individuals, -50000, 0.0011m),
                new DepositAccount("Gergana", "Petrova", CustomerType.companies, 1000000, 0.00075m),
            };

            Console.WriteLine(
                "12-month interest on a deposit account (balance: {0:c2}, rate: {1:f3}%): {2:c2}",
                accounts[0].Balance,
                accounts[0].InterestRate * 100,
                accounts[0].CalculateInterest(12));

            Console.WriteLine(
                "3-month interest on a loan account (balance: {0:c2}, rate: {1:f3}%): {2:c2}",
                accounts[1].Balance,
                accounts[1].InterestRate * 100,
                accounts[1].CalculateInterest(3));

            Console.WriteLine(
                "15-month interest on a mortgage account (balance: {0:c2}, rate: {1:f3}%): {2:c2}",
                accounts[2].Balance,
                accounts[2].InterestRate * 100,
                accounts[2].CalculateInterest(15));

            Console.WriteLine(
                "24-month interest on a deposit account (balance: {0:c2}, rate: {1:f3}%): {2:c2}",
                accounts[3].Balance,
                accounts[3].InterestRate * 100,
                accounts[3].CalculateInterest(24));
        }
    }
}