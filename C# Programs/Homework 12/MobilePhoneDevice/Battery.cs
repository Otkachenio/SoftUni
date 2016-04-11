using System;

class Battery
{
    private string modelBattery;
    private int hoursIdle;
    private int hoursTalk;

    public string ModelBattery
    {
        get { return this.modelBattery; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ApplicationException("Battery model can NOT be null or empty!");
            }
            this.modelBattery = value;
        }
    }

    public int HoursIdle
    {
        get { return this.hoursIdle; }
        set
        {
            if (value < 0)
            {
                throw new ApplicationException("Cannot be a negative number!");
            }
            this.hoursIdle = value;
        }
    }

    public int HoursTalk
    {
        get { return this.hoursTalk; }
        set
        {
            if (value < 0)
            {
                throw new ApplicationException("Cannot be a negative number!");
            }
            this.hoursTalk = value;
        }
    }
    
    public Battery(string modelBattery, int hoursIdle, int hoursTalk)
    {
        this.ModelBattery = modelBattery;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
    }
}

