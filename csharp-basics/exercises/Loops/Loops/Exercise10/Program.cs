using System;

namespace Exercise10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min?");
            int numberMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max?");
            int numberMax = Convert.ToInt32(Console.ReadLine());

            for (int i = numberMin; i <= numberMax; i++)
            {
                for (int j = i; j <= numberMax; j++)
                {
                    Console.Write(j);
                }

                for (int j = numberMin; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
