﻿using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = int.Parse(Console.ReadLine());

            if (input > 0)
            {
                Console.WriteLine("Number2 is positive");
            } 
            else if (input < 0) 
            {
                Console.WriteLine("Number is negative");
            } 
            else 
            {
                Console.WriteLine("Number is zero");
            }

            Console.ReadKey();
        }
    }
}
