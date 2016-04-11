using System;
class Program
{
    static void Main(string[] args)
    {
        var amount = decimal.Parse(Console.ReadLine());
        var inputCurrency = Console.ReadLine();
        var outputCurrency = Console.ReadLine();

        if (inputCurrency == "USD") //Converting from USD to levs
        {
            amount = amount * 1.79549m;
        }

        else if (inputCurrency == "EUR") //Converting from EUR to levs
        {
            amount = amount * 1.95583m;
        }

        else if (inputCurrency == "GBP") //Converting from GBP to levs
        {
            amount = amount * 2.53405m;
        }

        if (outputCurrency == "BGN")
        {

        }

        else if (outputCurrency == "USD")
        {
            amount = amount / 1.79549m;
        }

        else if (outputCurrency == "EUR")
        {
            amount = amount / 1.95583m;
        }

        else if (outputCurrency == "GBP")
        {
            amount = amount / 2.53405m;
        }

        Console.WriteLine(Math.Round(amount, 2));
    }
}