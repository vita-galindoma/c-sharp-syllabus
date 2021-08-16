using System;

namespace Exercise4_2
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
            switch (input)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not a valid day.");
                    break;
            }
        }
    }
}
