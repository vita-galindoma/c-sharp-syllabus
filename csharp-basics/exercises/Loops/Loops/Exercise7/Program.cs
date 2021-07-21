using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNum = random.Next(1, 6);
            Console.WriteLine("Welcome to Piglet!");
            Console.WriteLine($"You rolled a {randomNum}!");
            if (randomNum == 1)
            {
                Console.WriteLine("You rolled a 1! You got 0 points. Game is over.");
            }
            else
            {
                var score = +randomNum;
                Console.WriteLine("Roll again? y/n");
                string answer = Console.ReadLine();

                while (true)
                {
                    if (answer == "y")
                    {
                        randomNum = random.Next(1, 6);
                        if (randomNum == 1)
                        {
                            Console.WriteLine("You rolled a 1! You got 0 points. Game is over.");
                            break;
                        }
                        else
                        {
                            score += randomNum;
                            Console.WriteLine($"You rolled a {randomNum}!");
                            Console.WriteLine("Roll again? y/n");
                            answer = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"You got {score} points.");
                        break;
                    }
                }
            }
        }
    }
}
