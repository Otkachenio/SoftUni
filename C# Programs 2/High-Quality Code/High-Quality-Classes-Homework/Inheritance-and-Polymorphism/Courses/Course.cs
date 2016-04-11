namespace InheritanceAndPolymorphism.Courses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string courseName;
        private string teacherName;

        public IList<string> Students { get; set; }

        public Course(string courseName, string teacherName = null,
            List<string> students = null)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value == "")
                {
                    throw new ArgumentNullException("Course name cannot be null.");
                }

                this.courseName = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                this.teacherName = value;
            }
        }
     
        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder course = new StringBuilder();

            course.Append(string.Format(" Name = {0}",
                this.CourseName));
            if (this.TeacherName != null)
            {
                course.Append(string.Format("; Teacher = {0}", this.TeacherName));
            }
            course.Append("; Students = ");
            course.Append(this.GetStudentsAsString());

            return course.ToString();
        }
    }
}