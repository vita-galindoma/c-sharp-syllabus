using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word/letters using both upper and lowercase letters: ");
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    count++;
                }
            }

            Console.WriteLine($"The number of the uppercase letters: {count}");
        }
    }
}
