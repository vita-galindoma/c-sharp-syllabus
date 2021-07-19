using System;

namespace Exercise5
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
                switch (letter)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        Console.Write(2); break;
                    case 'd':
                    case 'e':
                    case 'f':
                        Console.Write(3); break;
                    case 'g':
                    case 'h':
                    case 'i':
                        Console.Write(4); break;
                    case 'j':
                    case 'k':
                    case 'l':
                        Console.Write(5); break;
                    case 'm':
                    case 'n':
                    case 'o':
                        Console.Write(6); break;
                    case 'p':
                    case 'r':
                    case 'q':
                    case 's':
                        Console.Write(7); break;
                    case 't':
                    case 'u':
                    case 'v':
                        Console.Write(8); break;
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        Console.Write(7); break;
                    default:
                        Console.Write("Not a valid char!"); break;
                }
            }
        }
    }
}
