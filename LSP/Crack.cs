using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Crack : Player, ICrack
    {
        public override void CalculateValue(int lastPerformance)
        {
            const decimal baseValue = 32.75M;

            Value = baseValue + (lastPerformance * 4);
        }

        public void TrainPenaltyKicks()
        {
            Console.WriteLine("I'm training my penalty kicks");
        }
    }
}
