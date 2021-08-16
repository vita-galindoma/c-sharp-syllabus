using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            WageCalculator(7.5, 35);
            WageCalculator(8.2, 47);
            WageCalculator(10, 73);
            Console.ReadKey();
        }

        static void WageCalculator(double basePay, int hoursWorked)
        {
            int minWage = 8;
            int maxHoursPerWeek = 60;
            int baseHoursPerWeek = 40;

            if (hoursWorked > maxHoursPerWeek)
            {
                Console.WriteLine($"Error! Employee has worked {hoursWorked} hours, only 60 hours per week allowed.");
            }
            else if (basePay < minWage)
            {
                Console.WriteLine($"Error! The base pay ${basePay} is less than the minimum wage ($8.00 an hour).");
            }
            else if (hoursWorked > baseHoursPerWeek)
            {
                double result = basePay * 40 + 1.5 * basePay * (hoursWorked - 40);
                Console.WriteLine($"Total salary is ${result}.");
            }
            else
            {
                double result = basePay * hoursWorked;
                Console.WriteLine($"Total salary is ${result}.");
            }
        }
    }
}
