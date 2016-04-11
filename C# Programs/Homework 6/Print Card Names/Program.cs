using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Card_Names
{
    class Program
    {
        static void Main()
        {
            string[] cardName = new string[] {"Clubs", "Diamonds", "Hearts", "Spades"};
            int cardNameNumber = 0;
            int numberCard = 2;
            for (int n = 0; n <= 52; n++)
            {
                switch (n)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("Ace of " + cardName[cardNameNumber]);
                        cardNameNumber++;
                        break;
                }
                if (cardNameNumber > 3 && n<5)
                {
                    cardNameNumber = 0;
                    for (int p = 1; p <= 44; p++)
                    {
                        if (cardNameNumber < 4)
                        {
                            if (p % 5 == 0)
                            {
                                numberCard++;

                            }
                            else
                            {
                                Console.WriteLine(numberCard + " of " + cardName[cardNameNumber]);
                                if (cardNameNumber < 3)
                                {
                                    cardNameNumber++;
                                }
                                else
                                {
                                    cardNameNumber = 0;
                                }
                            }
                        }
                    }
                }
                switch (n)
                {
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Jack of " + cardName[cardNameNumber]);
                        cardNameNumber++;
                        break;
                    case 9:
                        cardNameNumber = 0;
                        break;
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                        Console.WriteLine("Queen of " + cardName[cardNameNumber]);
                        cardNameNumber++;
                        break;
                    case 14:
                        cardNameNumber = 0;
                        break;
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                        Console.WriteLine("King of " + cardName[cardNameNumber]);
                        cardNameNumber++;
                        break;
                }
            }
        }
    }
}
