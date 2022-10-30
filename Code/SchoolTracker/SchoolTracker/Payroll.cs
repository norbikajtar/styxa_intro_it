
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    public class Payroll : Util.Console
    {
        List<IPayee> payees = new List<IPayee>();

        public Payroll(List<IPayee> list)
        {
            payees = list;
        }

        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }
        }

    }
}
