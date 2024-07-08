using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOLSP
{
    public class Captain : Player
    {
        public override void CalculateValue(int lastPerformance)
        {
            const decimal baseValue = 50M;
            Value = baseValue + (lastPerformance * 10);
        }

        public override void AssignReferencePlayer(Crack newIdol)
        {
            throw new InvalidOperationException("The captain has no reference player");
        }

        public void TrainPenalty()
        {
            Console.WriteLine("I'm training my penalty kicks");
        }

        public void TrainFreeKick()
        {
            Console.WriteLine("I'm training my free kicks");
        }
    }
}
