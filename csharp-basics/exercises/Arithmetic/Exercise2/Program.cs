using System;
using System.Transactions;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            CheckOddEven(int.Parse(Console.ReadLine()));
        }

        static void CheckOddEven(int number)
        {
            Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
            Console.WriteLine("Bye!");
        }
    }
}
