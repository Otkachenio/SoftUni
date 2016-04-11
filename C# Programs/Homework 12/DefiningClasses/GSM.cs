using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private static GSM iPhone4S;

        public GSM(string model, string manufacturer, double price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        static GSM()
        {
            iPhone4S = new GSM("iPhone 4S", "Apple", 300, "Apple");
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Model name must be atleast 2 chars long!");
                }
                this.model = value;
            }
        }

        public override string ToString()
        {
            Console.WriteLine("|)_------* G S M *------_(|");
            Console.WriteLine("Model: {0}", this.model);
            Console.WriteLine("Manufacturer: {0}", this.manufacturer);
            Console.WriteLine("Price: {0}$", this.price);
            Console.WriteLine("Owner: {0}", this.owner);
            Console.WriteLine();

            return base.ToString();
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Manudacturer name must be atleast 2 chars long!");
                }
                this.manufacturer = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can't be negative number!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Owner's name must be aleast 2 chars long!");
                }
                this.owner = value;
            }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }

        public List<Call> CallHistory = new List<Call>();

        public void AddCalls(DateTime dateAndTime, string dialedPhone, int duration)
        {
            Call call = new Call(dateAndTime, dialedPhone, duration);
            CallHistory.Add(call);
        }

        public void DeleteCalls(int duration)
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].Duration == duration)
                {
                    CallHistory.RemoveAt(i);
                    i--;
                }
            }
        }

        public void ClearCalls()
        {
            CallHistory.Clear();
        }

        public void CallPrice(double pricePerMinute)
        {
            double wholeTime = 0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                wholeTime += CallHistory[i].Duration;
            }
            double price = pricePerMinute * (Math.Ceiling(wholeTime / 60));
            Console.WriteLine("Total price: {0:F2}", price);
            Console.WriteLine();
        }

        public void PrintCalls()
        {
            for (int i = 0; i < CallHistory.Count; i++)
            {
                Console.WriteLine(")---------Calls---------(");
                Console.WriteLine("Date and time: {0}", CallHistory[i].DateAndTime);
                Console.WriteLine("Dialed phone number: {0}", CallHistory[i].DialedPhone);
                Console.WriteLine("Call duration: {0}", CallHistory[i].Duration);
                Console.WriteLine();
            }
        }
    }
}
