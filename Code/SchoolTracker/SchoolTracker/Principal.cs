using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    public class Principal : Person, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying Principal");
        }
    }
}
