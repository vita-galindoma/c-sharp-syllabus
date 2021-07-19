using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDayInWord();
            Console.ReadKey();
        }
        static void PrintDayInWord()
        {
            Console.WriteLine("Enter the number from 1 to 7.");
            var input = int.Parse(Console.ReadLine());
            if (input >= 1 && input <= 7)
            {
                if (input == 1)
                {
                    Console.WriteLine("Monday");
                }
                if (input == 2)
                {
                    Console.WriteLine("Tuesday");
                }
                if (input == 3)
                {
                    Console.WriteLine("Wednesday");
                }
                if (input == 4)
                {
                    Console.WriteLine("Wednesday");
                }
                if (input == 5)
                {
                    Console.WriteLine("Friday");
                }
                if (input == 6)
                {
                    Console.WriteLine("Saturday");
                }
                if (input == 7)
                {
                    Console.WriteLine("Sunday");
                }
            }
            else
            {
                Console.WriteLine("Not a valid day.");
            }
        }
    }
}