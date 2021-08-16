using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer: ");
            int y = int.Parse(Console.ReadLine());
            bool test = (x == 15) || (y == 15) || (x + y == 15) || Math.Abs(x + y) == 15;
            Console.WriteLine($"One of the integers or their sum is 15: {test}");
        }
    }
}
