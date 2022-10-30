using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> diakok = new List<Student>();

            List<IPayee> payees = new List<IPayee>();

            payees.Add(new Teacher() { Name = "Andor" });
            payees.Add(new Teacher());
            payees.Add(new Principal());

            var payroll = new Payroll(payees);
            payroll.PayAll();

            var next = true;

            var diak1 = new Student();

            diak1.Count++;
            Student.count++;

            var diak2 = new Student();

            diak2.Count++;
            Student.count++;

            while (next)
            {
                System.Console.WriteLine("Please provide a name:");
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

    }
}
