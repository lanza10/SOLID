using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP.Interfaces;

namespace DIP
{
    public static class Factory
    {
        public static ITruckDriver CreateDriver()
        {
            return new TruckDriver();
        }

        public static IJourney CreateJourney()
        {
            return new Journey(CreateLogger(), CreateMessageSender());
        }

        public static IMessageSender CreateMessageSender()
        {
            return new Emailer();
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

    }
}
