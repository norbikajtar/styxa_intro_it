using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    public class Teacher : Person, IPayee
    {
        public string Subject { get; set; }

        public void Pay()
        {
            Name = "";
            Console.WriteLine("Paying Teacher: {0}", Name);
        }
    }
}
