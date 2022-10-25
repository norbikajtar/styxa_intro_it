using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> diakok = new List<Student>();

            var next = true;

            while (next)
            {
                Console.WriteLine("Please provide a name:");
                var name = Console.ReadLine();

                Console.WriteLine("Please provide a grade:");
                var grade = int.Parse(Console.ReadLine());

                var diak = new Student(name, grade, "12323543645");
                Console.WriteLine(diak.GetPhone());
                diakok.Add(diak);

                Console.WriteLine("Add one more? y/n");
                var answer = Console.ReadLine();

                if (answer == "y")
                {
                    next = true;
                }
                else
                {
                    next = false;
                }
            }

            foreach (var diak in diakok)
            {
                Console.WriteLine("{0}: {1}", diak.Name, diak.Grade);
            }
        }

        public class Student
        {
            public Student(string name, int grade, string phone)
            {
                Name = name;
                Grade = grade;
                Phone = phone;
            }

            public void SetPhone(string phone)
            {
                Phone = phone;
            }

            public string GetPhone()
            {
                return Phone;
            }

            public string Name { get; set; }
            public int Grade { get; set; }
            private string Phone { get; set; }
            public DateTime Dateofbirth { get; set; }
        };

    }
}
