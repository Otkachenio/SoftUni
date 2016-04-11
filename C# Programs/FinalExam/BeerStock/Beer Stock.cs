using System;

class Program
{
    static void Main()
    {
        int reservedBeers = int.Parse(Console.ReadLine());
        string shipment = Console.ReadLine();
        long lNCases, lNSixPacks, lNBeers;
        long countBeers = 0;
        long beers;

        while (shipment != "Exam Over")
        {
            beers = int.Parse(shipment.Substring(0, 2));
            string beerPacks = shipment.Substring(2, 4);
            
            if (beerPacks == "sixp")
            {
                countBeers += (beers * 6);
            }
            else if (beerPacks == "case")
            {
                countBeers += (beers * 24);
            }
            else
            {
                countBeers +=  (beers * 1);
            }
            shipment = Console.ReadLine();
        }
        if (reservedBeers > countBeers)
        {
            beers = reservedBeers - countBeers;
            lNCases = beers / 24;
            lNSixPacks = (beers % 24) / 6;
            lNBeers = beers - ((lNCases * 24) + (lNSixPacks * 6));
            Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", lNCases, lNSixPacks, lNBeers);
        }
        else
        {
            countBeers = countBeers - (countBeers / 100);
            beers = countBeers - reservedBeers;
            lNCases = beers/ 24;
            lNSixPacks = (beers % 24) / 6;
            lNBeers = beers - (lNCases * 24) - (lNSixPacks * 6);

            Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", lNCases, lNSixPacks, lNBeers);
        }
    }
}