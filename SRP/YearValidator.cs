using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SRP
{
    public class YearValidator
    {
        public static bool ValidYear(string? year, BirthDate bd)
        {
            if (!IsNotNullData(year))
            {
                return false;
            }

            return IsParsableYear(year!, bd) && IsYearInRange(bd.Year);
        }

        public static bool IsNotNullData(string? year)
        {
            if (!string.IsNullOrWhiteSpace(year)) return true;
            Console.WriteLine("The year you inserted was empty!");
            return false;

        }
        public static bool IsParsableYear(string year, BirthDate bd)
        {
            if (int.TryParse(year, out bd.Year)) return true;
            Console.WriteLine("The year you inserted was not a number!");
            return false;

        }

        public static bool IsYearInRange(int year)
        {
            if (year is >= 0 and <= 2024) return true;
            Console.WriteLine("The year you inserted is out of range");
            return false;
        }
    }
}
