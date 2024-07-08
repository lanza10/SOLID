using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOLSP
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Crack ReferencePlayer { get; set; } = null;

        public decimal Value { get; set; }

        public virtual void AssignReferencePlayer(Crack newReference)
        {
            //Simulate tasks
            ReferencePlayer = newReference;
        }

        public virtual void CalculateValue(int lastPerformance)
        {
            const decimal baseValue = 1.50M;
            Value = baseValue + (lastPerformance * 2);
        }
    }
}
