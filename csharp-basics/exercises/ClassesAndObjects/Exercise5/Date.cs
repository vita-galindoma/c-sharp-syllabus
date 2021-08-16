using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Date
    {
        public Date(int month, int day, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        public int Month  { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }
}
