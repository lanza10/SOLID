using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NODIP
{
    public class Journey
    {
        public string Destination { get; set; }
        public TruckDriver Driver { get; set; }
        public double HoursDriven { get; private set; }
        public bool IsCompleted { get; private set; }

        public void PerformedDrive(double hours)
        {
            HoursDriven += hours;
            var log = new Logger();
            log.Log($"Drove {hours} hours to {Destination}");
        }

        public void CompleteJourney()
        {
            IsCompleted = true;

            var log = new Logger();
            log.Log($"Completed the journey to {Destination}");

            var emailer = new Emailer();
            emailer.SendEmail(Driver, $"The trip to {Destination} is complete. Thank you!");
        }
    }
}
