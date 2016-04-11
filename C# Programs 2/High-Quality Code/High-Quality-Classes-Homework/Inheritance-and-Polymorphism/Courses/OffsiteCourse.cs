namespace InheritanceAndPolymorphism.Courses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        public string Town { get; set; }

        public OffsiteCourse(
            string courseName, string teacherName = null, List<string> students = null) 
            : base(courseName, teacherName, students)
        {
            Town = null;
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse {");
            result.Append(base.ToString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}