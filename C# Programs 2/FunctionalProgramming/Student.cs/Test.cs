namespace Student.cs
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Test
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();

            studentsList.Add(new Student("Pesho", "Petrov", 30, "13579", "0892141516", "pesho@abv.bg",
                new List<int> { 3, 2, 2, 4, 3 }, 1, "The slow ones"));
            studentsList.Add(new Student("Peshe", "Getish", 20, "14789", "0888765432", "mrgetish@abv.bg",
                new List<int> { 4, 4, 5, 5, 3 }, 2, "The slow ones"));
            studentsList.Add(new Student("Gosho", "Georgiev", 31, "13296", "0877489511", "gogo@yahoo.com",
                new List<int> { 5, 4, 4, 2, 5 }, 1, "The slow ones"));
            studentsList.Add(new Student("Gergana", "Ivanova", 18, "17914", "0895321632", "geri@gmail.com",
                new List<int> { 6 , 5, 5, 4, 6 }, 2, "The best"));
            studentsList.Add(new Student("Aleksandar", "Emilov", 21, "77714", "0899111213", "otkachenio@mail.bg",
               new List<int> { 6, 6, 5, 6, 6 }, 2, "The best"));

            var studentByGroup = studentsList
                .Where(student => student.GroupNumber == 2)
                .OrderBy(student => student.FirstName);

            //foreach (var student in studentByGroup)
            //{
            //    Console.WriteLine(student);
            //}

            var studentsByFirstAndLastName = studentsList
                .Where(student => string.Compare(student.FirstName, student.LastName) < 0);

            //foreach (var student in studentsByFirstAndLastName)
            //{
            //    Console.WriteLine(student);
            //}

            var studentsByAge = studentsList
                .Where(student => student.Age >= 18)
                .Where(student => student.Age <= 24)
                .Select(student => String.Format("{0} {1} - Age: {2}",
                student.FirstName, student.LastName, student.Age));

            //foreach (var student in studentsByAge)
            //{
            //    Console.WriteLine(student);
            //}

            var sortStudents = studentsList
                .OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName);

            //foreach (var student in sortStudents)
            //{
            //    Console.WriteLine(student);
            //}

            var filterStudentsByEmail = studentsList
                .Where(student => student.Email.Contains("@abv.bg"));

            //foreach (var student in filterStudentsByEmail)
            //{
            //    Console.WriteLine(student);
            //}

            var firlterStudentsByPhone = studentsList
                .Where(student => student.Phone.StartsWith("089"));

            //foreach (var student in firlterStudentsByPhone)
            //{
            //    Console.WriteLine(student);
            //}

            var excellentStudents = studentsList
                .Where(student => student.Marks.Contains(6));

            //foreach (var student in excellentStudents)
            //{
            //    Console.WriteLine(student);
            //}

            var weakStudents = studentsList
                .Where(student => student.Marks.Where(mark => (mark == 2)).Count() == 2);

            //foreach (var student in weakStudents)
            //{
            //    Console.WriteLine(student);
            //}

            var studentsEnrolledIn2014 = studentsList
                .Where(student => student.FacultyNumber.EndsWith("14"));

            //foreach (var student in studentsEnrolledIn2014)
            //{
            //    Console.WriteLine(student);
            //}

            var groupedByName = studentsList
                .OrderBy(student => student.GroupName);

            foreach (var student in groupedByName)
            {
                Console.WriteLine(student);
            }
        }
    }
}