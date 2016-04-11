using System;

namespace DefiningClasses
{
    class Call
    {
        private DateTime dateAndTime;
        private string dialedPhone;
        private int duration;

        public Call(DateTime dateAndTime, string dialedPhone, int duration)
        {
            this.DateAndTime = dateAndTime;
            this.DialedPhone = dialedPhone;
            this.Duration = duration;
        }

        public DateTime DateAndTime
        {
            get { return dateAndTime; }
            set { dateAndTime = value; }
        }

        public string DialedPhone
        {
            get { return dialedPhone; }
            set { dialedPhone = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
