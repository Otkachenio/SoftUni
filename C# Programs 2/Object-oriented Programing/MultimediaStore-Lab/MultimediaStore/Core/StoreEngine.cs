namespace MultimediaStore.Core
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using MultimediaStore.Interfaces;
    using Models.Items;
    using MultimediaStore.Exceptions;

    public class StoreEngine
    {
        private const string DateTimeFormat = "dd-MM-yyyy";

        private IDictionary<IItem, int> supplies;

        public StoreEngine()
        {
            this.supplies = new Dictionary<IItem, int>();
        }

        public void Run()
        {
            while (true)
            {
                string inputLine = Console.ReadLine();
                string[] commandTokens = inputLine.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                switch (commandTokens[0])
                {
                    case "supply":
                        {
                            string type = commandTokens[1];
                            int quantity = int.Parse(commandTokens[2]);
                            string paramsString = commandTokens[3];

                            this.ExecuteSupplyCommand(type, paramsString, quantity);
                            break;
                        }
                    case "sell":
                        {
                            string id = commandTokens[1];
                            var item = this.GetItemById(id);
                            var saleDate = ToDateTime(commandTokens[2]);

                            this.ExecuteSaleCommand(item, saleDate);
                            break;
                        }
                    case "rent":
                        {
                            string id = commandTokens[1];
                            var item = this.GetItemById(id);
                            var rentDate = ToDateTime(commandTokens[2]);
                            var deadLine = ToDateTime(commandTokens[3]);

                            this.ExecuteRentCommand(item, rentDate, deadLine);
                            break;
                        }
                    case "report":
                        {
                            this.ExecuteReportCommand(commandTokens);
                            break;
                        }
                    default:
                        {
                            throw new InvalidOperationException("Invalid command!");
                        }
                }
            }
        }

        private void ExecuteReportCommand(string[] commandTokens)
        {
            string reportType = commandTokens[1];
            switch (reportType)
            {
                case "sales":
                    {
                        DateTime startDate = ToDateTime(commandTokens[2]);
                        decimal salesIncome = SaleManager.ReportSalesIncome(startDate);

                        Console.WriteLine("{0:F2}", salesIncome);
                        break;
                    }
                case "rents":
                    {
                        var overdueRents = RentManager.ReportOverdueRents();

                        Console.WriteLine(string.Join("\r\n", overdueRents));
                        break;
                    }
                default:
                    throw new ArgumentException("Invalid report type!");
            }
        }

        private void ExecuteRentCommand(IItem item, DateTime rentDate, DateTime deadLine)
        {
            if (this.supplies[item] == 0)
            {
                throw new InsufficientSuppliesException(
                    "There are not enough supplies to rent this item!");
            }

            RentManager.AddRent(item, rentDate, deadLine);
            this.supplies[item]--;
        }

        private void ExecuteSaleCommand(IItem item, DateTime saleDate)
        {
            if (this.supplies[item] == 0)
            {
                throw new InsufficientSuppliesException(
                    "There are not enough supplies to sell this item!");
            }

            SaleManager.AddSale(item, saleDate);
            this.supplies[item]--;
        }

        private void ExecuteSupplyCommand(string itemType, string paramsString, int quantity)
        {
            var itemParams = GetItemParams(paramsString);

            switch (itemType)
            {
                case "book":
                    {
                        string id = itemParams["id"];
                        string title = itemParams["title"];
                        string author = itemParams["author"];
                        decimal price = decimal.Parse(itemParams["price"]);
                        string genre = itemParams["genre"];

                        var book = new Book(id, title, price, genre, author);
                        this.AddToSupplies(book, quantity);
                        break;
                    }
                case "video":
                    {
                        string id = itemParams["id"];
                        string title = itemParams["title"];
                        decimal price = decimal.Parse(itemParams["price"]);
                        string genre = itemParams["genre"];
                        int videoLength = int.Parse(itemParams["length"]);

                        var video = new Video(id, title, price, videoLength, genre);
                        this.AddToSupplies(video, quantity);
                        break;
                    }
                case "game":
                    {
                        string id = itemParams["id"];
                        string title = itemParams["title"];
                        decimal price = decimal.Parse(itemParams["price"]);
                        string genre = itemParams["genre"];
                        AgeRestriction ageRestriction = ToEnum(itemParams["ageRestriction"]);

                        var game = new Game(id, title, price, genre, ageRestriction);
                        this.AddToSupplies(game, quantity);
                        break;
                    }
                default:
                    throw new ArgumentException("Invalid item type!");
            }
        }

        private void AddToSupplies(IItem item, int quantity)
        {
            if (!this.supplies.ContainsKey(item))
            {
                this.supplies[item] = 0;
            }

            this.supplies[item] += quantity;
        }

        private static IDictionary<string, string> GetItemParams(string paramsString)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            string[] pairs = paramsString.Split('&');

            foreach (var pair in pairs)
            {
                string[] keyValuePair = pair.Split('=');
                keyValuePairs[keyValuePair[0]] = keyValuePair[1];
            }

            return keyValuePairs;
        }

        private static DateTime ToDateTime(string dateString)
        {
            return DateTime.ParseExact(dateString, DateTimeFormat, CultureInfo.InvariantCulture);
        }

        private static AgeRestriction ToEnum(string enumString)
        {
            return (AgeRestriction)Enum.Parse(typeof(AgeRestriction), enumString);
        }

        private IItem GetItemById(string id)
        {
            return this.supplies
                .First(x => x.Key.Id == id)
                .Key;
        }
    }
}