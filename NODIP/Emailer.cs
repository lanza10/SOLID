using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NODIP
{
    public class Emailer
    {
        public void SendEmail(TruckDriver truckDriver, string message)
        {
            Console.WriteLine($"Sending email to {truckDriver.EmailAddress}");
        }
    }
}
