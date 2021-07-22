using System;
using System.ComponentModel.Design;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desired sum:");
            int desiredSum = Convert.ToInt32(Console.ReadLine());
            int randomNum1 = 0;
            int randomNum2 = 0;
            
            while (randomNum1 + randomNum2 != desiredSum)
            {
                Random random = new Random();
                randomNum1 = random.Next(1, 6);
                randomNum2 = random.Next(1, 6);
                int sumOfRandom = randomNum1 + randomNum2;

                Console.WriteLine($"{randomNum1} and {randomNum2} = {sumOfRandom}");
            }
            Console.ReadKey();
        }
    }
}
