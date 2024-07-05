using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class StandardMessages
    {
        public static void SayWelcome()
        {
            Console.WriteLine("Welcome!");
        }

        public static void AskForData(string data)
        {
            Console.WriteLine($"Insert the {data} you were born:");
        }
    }
}
