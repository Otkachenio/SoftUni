using System;
using System.Collections.Generic;

namespace Problem1.School
{
    class Student : People
    {
        private int classNumber;

        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Class number cannot be less than 1 !");
                }
                if (value > 40)
                {
                    throw new ArgumentException("Class number cannot be bigger than 40 !");
                }

                this.classNumber = value;
            }
        }
    }
}