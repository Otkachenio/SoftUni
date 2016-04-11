namespace NightlifeEntertainment.Core
{
    using System;
    using System.Linq;

    using NightlifeEntertainment.Tickets;
    using NightlifeEntertainment.Performances;
    using NightlifeEntertainment.Venues;

    public class ExtendedCinemaEngine : CinemaEngine
    {
        public ExtendedCinemaEngine() : base()
        {
        }

        protected override void ExecuteReportCommand(string[] commandWords)
        {
            var performance = this.GetPerformance(commandWords[1]);
            decimal totalMoney = 0;
            int ticketsSold = 0;

            foreach (var pricePerTicket in performance.Tickets)
            {
                if (pricePerTicket.Status.Equals(TicketStatus.Sold))
                {
                    totalMoney += pricePerTicket.Price;
                    ticketsSold++;
                }              
            }

            this.Output.AppendLine(string.Format("{0}: {1} ticket(s), total: ${2:F2}",
                performance.Name, ticketsSold, totalMoney));
            this.Output.AppendLine(string.Format("Venue: {0} ({1})",
                performance.Venue.Name, performance.Venue.Location));
            this.Output.AppendLine(string.Format("Start time: {0}", performance.StartTime));
        }

        protected override void ExecuteSupplyTicketsCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[2]);
            var performance = this.GetPerformance(commandWords[3]);

            switch (commandWords[1])
            {
                case "student":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new StudentTicket(performance));
                    }
                    break;
                case "vip":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new VIPTicket(performance));
                    }
                    break;
                default:
                    base.ExecuteSupplyTicketsCommand(commandWords);
                    break;
            }           
        }

        protected override void ExecuteInsertVenueCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "concert_hall":
                    var convertHall = new ConcertHall(commandWords[3], commandWords[4],
                        int.Parse(commandWords[5]));
                    this.Venues.Add(convertHall);
                    break;
                case "opera":
                    var opera = new OperaHall(commandWords[3], commandWords[4],
                        int.Parse(commandWords[5]));
                    this.Venues.Add(opera);
                    break;
                case "sports_hall":
                    var sportsHall = new SportsHall(commandWords[3], commandWords[4],
                        int.Parse(commandWords[5]));
                    this.Venues.Add(sportsHall);
                    break;
                default:
                    base.ExecuteInsertVenueCommand(commandWords);
                    break;
            }           
        }

        protected override void ExecuteInsertPerformanceCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "theatre":
                    var venue = this.GetVenue(commandWords[5]);
                    var theatre = new Theatre(commandWords[3], decimal.Parse(commandWords[4]),
                        venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(theatre);
                    break;
                case "concert":
                    var ConcertVenue = this.GetVenue(commandWords[5]);
                    var concert = new Concert(commandWords[3], decimal.Parse(commandWords[4]),
                        ConcertVenue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(concert);
                    break;
                default:
                    base.ExecuteInsertPerformanceCommand(commandWords);
                    break;
            }                     
        }

        protected override void ExecuteFindCommand(string[] commandWords)
        {
            string searchWord = commandWords[1];
            string date = commandWords[2] + " " +  commandWords[3];
            DateTime dateForSearch = DateTime.Parse(date);
            int counter = 0;

            this.Output.AppendLine(string.Format("Search for \"{0}\"", searchWord));

            this.Output.AppendLine("Performances:");
            foreach (var performance in Performances
                                            .OrderBy(p => p.StartTime)
                                            .ThenByDescending(p => p.BasePrice)
                                            .ThenBy(p => p.Name))
            {
               if (performance.Name.ToLower().Contains(searchWord.ToLower()) &&
                    performance.StartTime >= dateForSearch)
                {
                    this.Output.AppendLine("-" + performance.Name);
                    counter++;
                }              
            }

            if (counter == 0)
            {
                this.Output.AppendLine("no results");
            }
            counter = 0;

            this.Output.AppendLine("Venues:");
            foreach (var venue in Venues.OrderBy(v => v.Name))
            {
                if (venue.Name.ToLower().Contains(searchWord.ToLower()))
                {
                    this.Output.AppendLine("-" + venue.Name);
                    foreach (var per in Performances)
                    {
                        if (per.Venue.Name.Equals(venue.Name) && per.StartTime >= dateForSearch)
                        {
                            this.Output.AppendLine("--" + per.Name);
                        }
                    }
                    counter++;
                }
            }

            if (counter == 0)
            {
                this.Output.AppendLine("no results");
            }
        }
    }
}