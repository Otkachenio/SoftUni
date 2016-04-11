using System;

namespace Problem2_LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int RAM;
        private string graphicsCard;
        private string HDD;
        private string screen;
        private decimal price;
        private Battery battery = new Battery();

        public Laptop(string model,
                    decimal price,
                    string manufacturer = null,
                    string processor = null,
                    int RAM = 0,
                    string graphicsCard = null,
                    string HDD = null,
                    string screen = null,
                    string batteryModel = null,
                    string batteryLife = null)
        {
            this.Model = model;
            this.Price = price;
            this.manufacturer = manufacturer;
            this.processor = processor;
            this.RAM = RAM;
            this.graphicsCard = graphicsCard;
            this.HDD = HDD;
            this.screen = screen;
            this.battery.BatteryModel = batteryModel;
            this.battery.BatteryLife = batteryLife;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Trim().Length < 6)
                {
                    throw new ArgumentException("Model must be at least 6 chars length!");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Model cannot be more than 50 chars long!");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Price must be positive number bigger than 1");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            Console.WriteLine("Model: " + this.model);
            if (!String.IsNullOrEmpty(this.manufacturer))
            {
                Console.WriteLine("Manufacturer: " + this.manufacturer);
            }
            if (!String.IsNullOrEmpty(this.processor))
            {
                Console.WriteLine("Processor: " + this.processor);
            }
            if (RAM >= 1)
            {
                Console.WriteLine("RAM: " + this.RAM + " GB");
            }
            if (!String.IsNullOrEmpty(this.graphicsCard))
            {
                Console.WriteLine("Grapics Card: " + this.graphicsCard);
            }
            if (!String.IsNullOrEmpty(this.HDD))
            {
                Console.WriteLine("HDD: " + this.HDD);
            }
            if (!String.IsNullOrEmpty(this.screen))
            {
                Console.WriteLine("Screnn: " + this.screen);
            }
            if (battery.BatteryModel != null)
            {
                Console.WriteLine("Battery: " + this.battery.BatteryModel);
            }
            if (battery.BatteryLife != null)
            {
                Console.WriteLine("Battery life: " + this.battery.BatteryLife);
            }
                     
            Console.WriteLine("Price: " + price + " lv.");
            return "";
        }
    }
}
