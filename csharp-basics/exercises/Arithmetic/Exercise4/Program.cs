using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product1ToN(10);
        }

        static void Product1ToN(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            } 
            Console.WriteLine($"The product of integers from 1 to {n} is {factorial}. ");
        }
    }
}
