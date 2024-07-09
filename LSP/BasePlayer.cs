using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public abstract class BasePlayer : IPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Value { get; set; }

        public virtual void CalculateValue(int lastPerformance)
        {
            const decimal baseValue = 1.50M;
            Value = baseValue + (lastPerformance * 2);
        }
    }
}
