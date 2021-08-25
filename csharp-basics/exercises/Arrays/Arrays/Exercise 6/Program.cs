using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomArray = ArrayExtensions.CreateRandomArray(10);
            var copiedArray = ArrayExtensions.CopyArray(randomArray);

            Console.WriteLine(String.Join(" ", randomArray));
            Console.WriteLine(String.Join(" ", copiedArray));

            Console.ReadKey();
        }
    }
}
