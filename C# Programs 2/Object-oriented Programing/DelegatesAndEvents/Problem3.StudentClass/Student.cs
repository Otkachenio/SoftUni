namespace Problem3.StudentClass
{
    using System;

    class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public event EventHandler<PropertyChangedEventArgs<string>> PropertyChanged;

        public string Name
        {
            get { return this.name; }

            set
            {
                if (value.Trim().Length < 2)
                {
                    throw new ArgumentException("Name must be at least 2 chars long!");
                }

                this.OnPropertyChange(new PropertyChangedEventArgs<string>("Name", this.name, value)); 

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative!");
                }

                this.OnPropertyChange(new PropertyChangedEventArgs<string>(
                    "Age", this.age.ToString(), value.ToString()));

                this.age = value;
            }
        }
        
        public virtual void OnPropertyChange(PropertyChangedEventArgs<string> e)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, e);
            }
        }
    }
}