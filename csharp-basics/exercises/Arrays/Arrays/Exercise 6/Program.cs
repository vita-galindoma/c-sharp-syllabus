using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = new int[10];
            Random randomNum = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = randomNum.Next(1, 100);
            }

            int[] copiedArray = new int[10];
            Array.Copy(randomArray, copiedArray, 10);

            randomArray[9] = -7;

            Console.WriteLine(String.Join(" ", randomArray));
            Console.WriteLine(String.Join(" ", copiedArray));

            Console.ReadKey();
        }
    }
}
