using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarServici
{
    static class DateHelper
    {
        public static List<DateTime> getAllDates(int year, int month)
        {
            var ret = new List<DateTime>();
            for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
            {
                ret.Add(new DateTime(year, month, i));
            }
            return ret;
        }

        public static int getDayOfWeek(int year, int month, int day)
        {
            DateTime dateValue = new DateTime(year, month, day);
            return (int)dateValue.DayOfWeek;
        }


    }
}
