using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name.");
            var name = Console.ReadLine();
            Console.WriteLine("Enter year of birth.");
            int.TryParse(Console.ReadLine(), out var birthYear);
            Console.WriteLine($"My name is {name} and I was born in {birthYear}.");
        }
    }
}
