using System;

namespace Problem1.School
{
    class Disciplines
    {
        private string name;
        private int numberOfLectures;
        private Student student;

        public Disciplines(string name, int numberOfLectures, Student student)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.student = student;
        }
    }
}
