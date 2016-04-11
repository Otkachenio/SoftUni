using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2.HumanStudentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();

            studentsList.Add(new Student("Pesho", "Peshev", "aaaaa"));
            studentsList.Add(new Student("Gosho", "Goshev", "bbbbb"));
            studentsList.Add(new Student("Niki", "Nikolov", "ccccc"));
            studentsList.Add(new Student("Velizarii", "Pulkovodec", "zzzzz"));
            studentsList.Add(new Student("Ivan", "Ivanov", "eeeee"));
            studentsList.Add(new Student("Gergana", "Georgieva", "xxxxx"));

            var sortedStudents = studentsList.OrderBy(x => x.FaultyNumber);
            PrintList(sortedStudents);

            Console.WriteLine("-----------------------");

            List<Worker> workersList = new List<Worker>();

            workersList.Add(new Worker("Pesho", "Kufteto", 125, 5));
            workersList.Add(new Worker("Gosho", "Trubata", 125, 5));
            workersList.Add(new Worker("Ivan", "Ivanov", 250, 10));
            workersList.Add(new Worker("Jelizar", "Vimov", 400, 8));
            workersList.Add(new Worker("G-n", "Sheff", 250, 5));
            workersList.Add(new Worker("Aleksandar", "Aleksandrov", 600, 8));

            var sorterWorkers = workersList.OrderBy(x => -x.MoneyPerHour());
            PrintList(sorterWorkers);

            Console.WriteLine();
            Console.WriteLine("___________---------__________");
            Console.WriteLine();

            List<Human> humansList = new List<Human>();

            humansList.AddRange(studentsList);
            humansList.AddRange(workersList);

            var sortedHumans = humansList.OrderBy(x => x.FirstName);
            PrintList(sortedHumans);
        }

        public static void PrintList(IOrderedEnumerable<Student> list)
        {
            foreach (var human in list)
            {
                Console.WriteLine(human);
            }
        }

        public static void PrintList(IOrderedEnumerable<Worker> list)
        {
            foreach (var human in list)
            {
                Console.WriteLine(human);
            }
        }

        public static void PrintList(IOrderedEnumerable<Human> list)
        {
            foreach (var human in list)
            {
                Console.WriteLine(human);
            }
        }
    }
}