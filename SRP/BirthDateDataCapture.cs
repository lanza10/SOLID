using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class BirthDateDataCapture
    {

        public static string? AskForData(string data)
        {
            Console.WriteLine($"Insert the {data} you were born:");
            return Console.ReadLine();
        }
    }
}
