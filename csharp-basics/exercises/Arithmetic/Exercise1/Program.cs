using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = Exercise1Extension.IsFifteen(1, 15);
            Console.WriteLine($"One of the integers or their sum is 15: {test}");

            Console.ReadKey();
        }
    }
}
