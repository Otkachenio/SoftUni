using System;
using System.Globalization;

namespace Problem2.HumanStudentWorker
{
    class Student : Human
    {
        private string faultyNumber;

        public Student(string firstName, string lastName, string faultyNumber
                                                    ) : base(firstName, lastName)
        {
            this.FaultyNumber = faultyNumber;
        }

        public string FaultyNumber
        {
            get
            {
                return this.faultyNumber;
            }

            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Faulty number must be between 5 and 10 chars!");
                }
                this.faultyNumber = value;
            }
        }

        public override string ToString()
        {
            string result = String.Format("{0} {1} - {2}",
                this.FirstName, this.LastName, this.faultyNumber);

            return result;
        }
    }
}