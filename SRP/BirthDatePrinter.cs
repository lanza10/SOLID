using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class BirthDatePrinter
    {
        public static void PrintBirthDate(BirthDate bd)
        {
            Console.WriteLine($"Your date of birth is {bd.Day}/{bd.Month}/{bd.Year}");
        }
    }
}
