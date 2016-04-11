using System;

namespace Problem1.School
{
    public abstract class People
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Trim().Length < 2)
                {
                    throw new ArgumentException("Name cannot be less than 2 chars long!");
                }

                this.name = value;
            }
        }
    }
}
