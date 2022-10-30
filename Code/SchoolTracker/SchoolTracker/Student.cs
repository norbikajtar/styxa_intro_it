using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolTracker
{
    public class Student : Person
    {
        public static int count = 0;

        public Student(string name, int grade, string phone)
        {
            Name = name;
            Grade = grade;
            Phone = phone;
        }

        public Student()
        {

        }

        public void SetPhone(string phone)
        {
            Phone = phone;
        }

        public string GetPhone()
        {
            return Phone;
        }

        public int Grade { get; set; }
        public int Count { get; set; }
    }
}
