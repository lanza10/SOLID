using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Captain : BasePlayer, ICrack
    {
        public override void CalculateValue(int lastPerformance)
        {
            const decimal baseValue = 50M;
            Value = baseValue + (lastPerformance * 10);
        }

        public void TrainPenaltyKicks()
        {
            Console.WriteLine("I'm training my penalty kicks");
        }

        public void TrainFreeKick()
        {
            Console.WriteLine("I'm training my free kicks");
        }
    }
}
