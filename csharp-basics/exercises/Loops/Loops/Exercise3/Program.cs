using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = new int[20];
            Random randNum = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = randNum.Next(0, 50);
                //Console.WriteLine($"{randomArray[i]} ");
            }

            Console.WriteLine("Which number position out of 20 random numbers (between 0 and 50) would you like to know?");
            int n = Convert.ToInt32(Console.ReadLine());
            int index = Array.IndexOf(randomArray, n);

            if (index > 0)
            {
                Console.WriteLine($"{n} position is: {index}");
            }
            else
            {
                Console.WriteLine("Not found.");
            }
            Console.ReadKey();
        }
    }
}
