using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP.Interfaces;

namespace DIP
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(ITruckDriver truckDriver, string message)
        {
            Console.WriteLine($"Sending email to {truckDriver.EmailAddress}");
        }
    }
}
