using System;

class Display
{
    private double displaySize = 0.0;
    private int numberOfColors = 1;

    public double DisplaySize
    {
        get { return this.displaySize; }
        set
        {
            if (value < 0)
            {
                throw new ApplicationException("Cannot be a negative number!");
            }
            this.displaySize = value;
        }
    }

    public int NumberOfColors
    {
         get { return this.numberOfColors; }
        set
        {
            if (value < 0)
            {
                throw new ApplicationException("Cannot be a negative number!");
            }
        }
    }

    public Display (double displaySize, int numberOfColors)
    {
        this.DisplaySize = displaySize;
        this.NumberOfColors = numberOfColors;
    }
}

