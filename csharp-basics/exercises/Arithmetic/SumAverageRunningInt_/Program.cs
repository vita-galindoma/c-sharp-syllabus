﻿using System;

namespace SumAverageRunningInt_
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            const int lowerBound = 1;
            const int upperBound = 100;
            
            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
            }

            double average = (double)sum / upperBound;

            Console.WriteLine($"The sum of {lowerBound} and {upperBound} is {sum}");
            Console.WriteLine($"The average is {average}");
        }
    }
}