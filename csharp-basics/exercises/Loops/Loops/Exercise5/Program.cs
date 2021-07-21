using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalLineLength = 30;
            Console.WriteLine("Enter first word:");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Enter first word:");
            string secondWord = Console.ReadLine();

            Console.Write(firstWord);
            for (int i = 0; i < 30 - firstWord.Length - secondWord.Length; i++)
            {
                Console.Write(".");
            }
            Console.Write(secondWord);
            Console.ReadKey();
        }
    }
}
