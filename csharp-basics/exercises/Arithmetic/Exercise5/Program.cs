using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int rInt = r.Next(0, 100);
            Console.WriteLine("I'm thinking of a number between 1-100. Try to guess it.");
            int random = Int32.Parse(Console.ReadLine());

            if (random > rInt)
            {
                Console.WriteLine($"Sorry, you are too high. I was thinking of {rInt}.");
            } 
            else if (random < rInt)
            {
                Console.WriteLine($"Sorry, you are too low. I was thinking of {rInt}.");
            }
            else
            {
                Console.WriteLine($"You guessed it!  What are the odds?!?");
            }
        }
    }
}