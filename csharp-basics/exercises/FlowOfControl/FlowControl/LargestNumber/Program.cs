﻿using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            int input3 = int.Parse(Console.ReadLine());

            int max = Math.Max(input1, Math.Max(input2, input3));
            
            Console.WriteLine($"The largest number of {input1}, {input2} and {input3} is {max}.");

            Console.ReadKey();
        }
    }
}