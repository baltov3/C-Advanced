using System;
using System.Collections.Generic;
using System.Linq;

namespace educationProject
{
    class Student
    {
        public Student(int age,string name)
        {
            this.Name = name;
            this.Age = age;

        }

        public int Age { get; set; }
        public string Name { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                students.Add(new Student(int.Parse(input[1]), input[0]));
            }
            string filterInput = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Student,int, bool> filter = GetFilter(filterInput);
            students = students.Where(x => filter(x, ageFilter)).ToList();
            Action<Student> printer = GetPrinted(format);
            students.ForEach(printer);
        }

        private static Action<Student> GetPrinted(string format)
        {
            switch (format)
            {
                case "name":
                    return s => Console.WriteLine(s.Name);
                case "age":
                     return s => Console.WriteLine(s.Age);
                    case "name age":
                     return s => Console.WriteLine($"{s.Name} - {s.Age}");

                default:
                    return null;
            }
        }

        private static Func<Student,int, bool> GetFilter(string filter)
        {
            switch (filter)
            {
                case "older":
                    return (s, age) => s.Age >= age;
                case "younger":
                    return (s, age) => s.Age < age;

                default:
                    return null;
            }
        }
    }
}
