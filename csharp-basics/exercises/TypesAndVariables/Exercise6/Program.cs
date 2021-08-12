using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of max 10 digits: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number != 0)
            {
                int remainder = number % 10;
                number = number / 10;
                sum = sum + remainder;
            }

            Console.WriteLine($"The sum of digits: {sum}");
        }
    }
}
