using System;

namespace DefiningClasses
{
    class Battery
    {
        public enum BatteryType
        {
            LiIon, NiMH, NiCd
        }

        private BatteryType batteryModel;
        private int hoursIdle;
        private int hoursTalk;

        public Battery(BatteryType batteryModel, int hoursIdle, int hoursTalk)
        {
            this.batteryModel = batteryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public BatteryType BatteryModel
        {
            get { return this.batteryModel; }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours Idle can't be negative number!");
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
                    throw new ArgumentException("Hours talk can't be negative number!");
                }
                this.hoursTalk = value;
            }
        }
    }
}
