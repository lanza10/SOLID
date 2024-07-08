using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SRP
{
    public class MonthValidator
    {
        public static bool ValidMonth(string? month, BirthDate bd)
        {
            if (!IsNotNullData(month))
            {
                return false;
            }

            return IsParsableMonth(month!, bd) && IsMonthInRange(bd.Month);

        }

        public static bool IsNotNullData(string? month)
        {
            if (!string.IsNullOrWhiteSpace(month)) return true;
            Console.WriteLine("The month you inserted was empty!");
            return false;

        }
        public static bool IsParsableMonth(string month, BirthDate bd)
        {
            if (int.TryParse(month, out bd.Month)) return true;
            Console.WriteLine("The month you inserted was not a number!");
            return false;

        }

        public static bool IsMonthInRange(int month)
        {
            if (month is >= 0 and <= 12) return true;
            Console.WriteLine("The month you inserted is out of range");
            return false;
        }
    }
}
