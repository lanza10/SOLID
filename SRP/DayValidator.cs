using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class DayValidator
    {
        public static bool ValidDay(string? day, BirthDate bd)
        {
            if (!IsNotNullData(day))
            {
                return false;
            }

            return IsParsableDay(day!, bd) && IsDayInRange(bd.Day);

        }
        public static bool IsNotNullData(string? day)
        {
            if (!string.IsNullOrWhiteSpace(day)) return true;
            Console.WriteLine("The day you inserted was empty!");
            return false;

        }
        public static bool IsParsableDay(string day, BirthDate bd)
        {
            if (int.TryParse(day, out bd.Day)) return true;
            Console.WriteLine("The day you inserted was not a number!");
            return false;

        }

        public static bool IsDayInRange(int day)
        {
            if (day is >= 0 and <= 31) return true;
            Console.WriteLine("The day you inserted is out of range");
            return false;
        }
    }
}
