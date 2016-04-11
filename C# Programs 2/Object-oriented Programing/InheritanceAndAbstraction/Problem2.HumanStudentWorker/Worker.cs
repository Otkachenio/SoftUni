using System;

namespace Problem2.HumanStudentWorker
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName,
                        decimal weekSalary, int workHoursPerDay) : base (firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary;  }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary cannot be negative number!");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }

            set
            {
                if (workHoursPerDay < 0)
                {
                    throw new ArgumentException("Work hours per day cannot be negative number!");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = (WeekSalary / WorkHoursPerDay) / 5;
            return moneyPerHour;
        }

        public override string ToString()
        {
            string result = String.Format("{0} {1} - {2}/hour",
                    this.FirstName, this.LastName, MoneyPerHour());

            return result;
        }
    }
}