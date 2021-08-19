using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
{
    public class Exercise8Extension
    {
        private double _basePay;
        private int _hoursWorked;

        public Exercise8Extension(double basePay, int hoursWorked)
        {
            if (basePay < 0 || hoursWorked < 0)
            {
                throw new ArgumentException("Base pay and hours worked should be positive");
            }
            _basePay = basePay;
            _hoursWorked = hoursWorked;
        }
        public string WageCalculator()
        {
            int minWage = 8;
            int maxHoursPerWeek = 60;
            int baseHoursPerWeek = 40;

            if (_hoursWorked > maxHoursPerWeek)
            {
                return $"Error! Employee has worked {_hoursWorked} hours, only 60 hours per week allowed.";
            }

            if (_basePay < minWage)
            {
                return $"Error! The base pay ${_basePay} is less than the minimum wage ($8.00 an hour).";
            }

            if (_hoursWorked > baseHoursPerWeek)
            {
                double result = _basePay * 40 + 1.5 * _basePay * (_hoursWorked - 40);
                return $"Total salary is ${result}.";
            }
            else
            {
                double result = _basePay * _hoursWorked;
                return $"Total salary is ${result}.";
            }
        }


    }
}
