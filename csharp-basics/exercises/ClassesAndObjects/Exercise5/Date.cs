using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Date(int day, int month, int year)
        {
            if (month < 0 || month > 12 || year < 0 || day < 0)
            {
                throw new ArgumentException("Incorrect date format");
            }
            if (month == 4 && day > 30 || month == 6 && day > 30 || month == 9 && day > 30 || month == 11 && day > 30)
            {
                throw new ArgumentException("Incorrect date format");
            }
            if (month == 1 && day > 31 || month == 2 && day > 31 || month == 3 && day > 31 || month == 5 && day > 31 || month == 7 && day > 31 || month == 8 && day > 31 || month == 10 && day > 31 || month == 12 && day > 31)
            {
                throw new ArgumentException("Incorrect date format");
            }
            Day = day;
            Month = month;
            Year = year;
        }
        
        public string DisplayDate()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
