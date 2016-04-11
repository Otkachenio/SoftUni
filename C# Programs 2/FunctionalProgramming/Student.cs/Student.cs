namespace Student.cs
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class Student
    {
        public Student(string firstName, string lastName, int age, string facultyNumber,
            string phone, string email, List<int> marks, int groupNumber, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public string GroupName { get; set; }

        public override string ToString()
        {
            StringBuilder student = new StringBuilder();

            student.AppendLine(String.Format("{0} {1} - age: {2}",
                this.FirstName, this.LastName, this.Age));
            student.AppendLine(String.Format("Faculty Number: {0}, Group Number: {1}",
                this.FacultyNumber, this.GroupNumber));
            student.AppendLine(String.Format("Phone: {0}, Email: {1}", this.Phone, this.Email));

            string marksAsString = String.Join(", ", this.Marks);
            student.AppendLine(String.Format("Marks: {0}", marksAsString));
            student.AppendLine(String.Format("Group Name: {0}", this.GroupName));

            return student.ToString();
        }
    }
}