using System;

namespace DefiningClasses
{
    class Display
    {
        private double dispaySize;
        private int numberOfColors;
        
        public Display(double dispaySize, int numberOfColors)
        {
            this.DisplaySize = dispaySize;
            this.NumberOfColors = numberOfColors;
        } 

        public double DisplaySize
        {
            get { return this.dispaySize; }
            set
            {
                if (value < 0 || value > 7)
                {
                    throw new ArgumentException("Display size can't be negative number or biggar than 7 inches!");
                }
                this.dispaySize = value;
            }
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value < 1 || value >= int.MaxValue)
                {
                    throw new ArgumentException("Number of colors must be more than 1 and small than \"int.MaxValue\"!");
                }
                this.numberOfColors = value;
            }
        }
        
    }
}
