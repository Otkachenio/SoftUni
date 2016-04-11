using System;
using System.Text;

class GSM
{
    private string model;
    private string manufacturer;
    private double price;
    private string owner;
    private Battery battery;
    private Display display;

    // Full Constructor
    public GSM(string model, string manufacturer, double price, string owner, string modelBattery, int hoursIdle,
    int hoursTalk, double size, int numberOfColors)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Owner = owner;
        this.battery = new Battery(modelBattery, hoursIdle, hoursTalk);
        this.display = new Display(size, numberOfColors);
    }
    // Part Constructor
    public GSM(string model, string manufacturer, double price)
        : this(model, manufacturer, price, null, null, 0, 0, 0, 0)
    {
    }
    // Override ToString(). I am using StringBulder to return string faster!
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append("Model: ").Append(Model).Append("\nPrice: ").Append(Price).Append("\nBattery: ").Append(battery.Type);
        // Ok i got the point that is borring!
        return result.ToString();
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (value.Length < 2)
            {
                throw new ApplicationException("The model name must be atleast 2 characters!");
            }
            this.model = value;
        }
    }
    
    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (value.Length < 2)
            {
                throw new ApplicationException("Manufacturer's name must be atleast 2 characters!");
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
                throw new ApplicationException("Price cannot be negative number!");
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
                throw new ApplicationException("Name of the owner must be atleast 2 characters!");
            }
            this.owner = value;
        }
    }
}

