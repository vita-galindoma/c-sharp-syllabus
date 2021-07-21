using System;

namespace Exercise8
{
    class AsciiFigure
    {
        static void Main(string[] args) {

            var lineCount = 7;
            for (int i = 1; i <= lineCount; i++)
            {
                int lineLength = (lineCount - 1) * 8;

                if (i == 1)
                {
                    Console.Write($"{new string('/',(lineCount - 1) * 4)}");
                    Console.Write($"{new string('\\', (lineCount - 1) * 4)}");
                    Console.WriteLine();
                }
                else if (i == lineCount)
                {
                    Console.WriteLine(new string('*', lineLength));
                }
                else
                {
                    Console.Write(new string('/', (lineLength - ((i - 1) * 8)) / 2));
                    Console.Write(new string('*', (i - 1) * 8));
                    Console.Write(new string('\\', (lineLength - ((i - 1) * 8)) / 2));
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
