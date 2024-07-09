using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP.Interfaces;

namespace DIP
{
    public class Journey : IJourney
    {
        private readonly ILogger _logger;
        private readonly IMessageSender _messageSender;
        public string Destination { get; set; }
        public ITruckDriver Driver { get; set; }
        public double HoursDriven { get; private set; }
        public bool IsCompleted { get; private set; }

        public Journey(ILogger logger, IMessageSender messageSender)
        {
            this._logger = logger;
            this._messageSender = messageSender;
        }

        public void PerformedDrive(double hours)
        {
            HoursDriven += hours;
            _logger.Log($"Drove {hours} hours to {Destination}");
        }

        public void CompleteJourney()
        {
            IsCompleted = true;

            _logger.Log($"Completed the journey to {Destination}");

            _messageSender.SendMessage(Driver, $"The trip to {Destination} is complete. Thank you!");
        }
    }
}
