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
                else if (input == 2)
                {
                    Console.WriteLine("Tuesday");
                }
                else if (input == 3)
                {
                    Console.WriteLine("Wednesday");
                }
                else if (input == 4)
                {
                    Console.WriteLine("Wednesday");
                }
                else if (input == 5)
                {
                    Console.WriteLine("Friday");
                }
                else if (input == 6)
                {
                    Console.WriteLine("Saturday");
                }
                else 
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