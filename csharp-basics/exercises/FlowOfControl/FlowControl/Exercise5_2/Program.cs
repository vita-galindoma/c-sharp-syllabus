using System;

namespace Exercise5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneKeyPad();
            Console.ReadKey();
        }
        static void PhoneKeyPad()
        {
            Console.WriteLine("Enter a string:");
            var input = Console.ReadLine().ToLower();
            char[] chars = input.ToCharArray();
            foreach (char letter in chars)
            {
                if (letter == 'a' || letter == 'b' || letter == 'c')
                {
                    Console.Write(2);
                }
                else if (letter == 'd' || letter == 'e' || letter == 'f')
                {
                    Console.Write(3);
                }
                else if (letter == 'g' || letter == 'h' || letter == 'i')
                {
                    Console.Write(4);
                }
                else if (letter == 'j' || letter == 'k' || letter == 'l')
                {
                    Console.Write(5);
                }
                else if (letter == 'm' || letter == 'n' || letter == 'o')
                {
                    Console.Write(6);
                }
                else if (letter == 'p' || letter == 'q' || letter == 'r' || letter == 's')
                {
                    Console.Write(7);
                }
                else if (letter == 't' || letter == 'u' || letter == 'v')
                {
                    Console.Write(8);
                }
                else if (letter == 'w' || letter == 'x' || letter == 'y' || letter == 'z')
                {
                    Console.Write(9);
                }
                else
                {
                    Console.Write("Not a valid char!");
                }
            }
        }
    }
}
