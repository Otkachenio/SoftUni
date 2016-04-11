using System;

namespace Problem2_LaptopShop
{
    class Battery
    {
        private string batteryModel;
        private string batteryLife;

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                this.batteryModel = value;
            }
        }

        public string BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                this.batteryLife = value;
            }
        }
    }
}
