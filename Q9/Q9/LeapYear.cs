using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    using System;
    using System.Net.Http.Headers;

    public class LeapYear
    {
        private int _InputYear;

        public LeapYear(int CurrentYear)
        {
            _InputYear = CurrentYear;
        }

        public bool IsLeapYear(int year)
        {
            return ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0));
            // checking if year can be divided by 4 but also cannot be divided by 100, but including division by 400
            // every 4 years is  a leap year but not every 100 years, except for exception of  every 400 years.
        }

        public void PrintNext20LeapYears()
        {
            int LeapCount = 0;
            Console.WriteLine("The Next 20 Leap years after the given year " + _InputYear + " is: ");
            // computing next 20 not including the input year
            for (int CrntYear = _InputYear+1; LeapCount <= 20; CrntYear++)
            {
                if (IsLeapYear(CrntYear))
                {
                    Console.WriteLine(CrntYear + "\n");
                    LeapCount++;
                }

            }


        }
    }
}
