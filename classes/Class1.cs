using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    using System;

    public class DateUtility
    {
        // Method to parse a string to a DateTime object
        public static DateTime ParseDate(string dateString)
        {
            DateTime result;
            if (DateTime.TryParse(dateString, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException("Invalid date format");
            }
        }

        // Method to calculate the difference between two dates
        public static TimeSpan CalculateDateDifference(DateTime date1, DateTime date2)
        {
            return date2 - date1;
        }

        // Method to format a date as a string
        public static string FormatDate(DateTime date, string format)
        {
            return date.ToString(format);
        }
    }

}
