using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new Date(10, 10, 2020);
            date.Year = 2021;
            date.Month = 8;
            date.Day = 31;

            Console.WriteLine(date.DisplayDate());
            Console.ReadKey();
        }
    }
}
