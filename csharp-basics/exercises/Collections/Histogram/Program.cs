using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path);
            string[] inputStrings = readText.Split(' ');

            List<int> inputInts = new List<int>();
            foreach (var element in inputStrings)
            {
                inputInts.Add(Int32.Parse(element));
            }

            Console.WriteLine(string.Join(" ", inputInts));
            
            var countTo09 = 0;
            var countTo19 = 0;
            var countTo29 = 0;
            var countTo39 = 0;
            var countTo49 = 0;
            var countTo59 = 0;
            var countTo69 = 0;
            var countTo79 = 0;
            var countTo89 = 0;
            var countTo99 = 0;
            var count100 = 0;

            foreach (var t in inputInts)
            {
                if (t >= 0 && t <= 09)
                {
                    countTo09++;
                }
                if (t >= 10 && t <= 19)
                {
                    countTo19++;
                }
                if (t >= 20 && t <= 29)
                {
                    countTo29++;
                }
                if (t >= 30 && t <= 39)
                {
                    countTo39++;
                }
                if (t >= 40 && t <= 49)
                {
                    countTo49++;
                }
                if (t >= 50 && t <= 59)
                {
                    countTo59++;
                }
                if (t >= 60 && t <= 69)
                {
                    countTo69++;
                }
                if (t >= 70 && t <= 79)
                {
                    countTo79++;
                }
                if (t >= 80 && t <= 89)
                {
                    countTo89++;
                }
                if (t >= 90 && t <= 99)
                {
                    countTo99++;
                }
                if (t == 100)
                {
                    count100++;
                }
            }

            Console.WriteLine($"00-09: {new String('*', countTo09)}");
            Console.WriteLine($"10-19: {new String('*', countTo19)}");
            Console.WriteLine($"20-29: {new String('*', countTo29)}");
            Console.WriteLine($"30-39: {new String('*', countTo39)}");
            Console.WriteLine($"40-49: {new String('*', countTo49)}");
            Console.WriteLine($"50-59: {new String('*', countTo59)}");
            Console.WriteLine($"60-69: {new String('*', countTo69)}");
            Console.WriteLine($"70-79: {new String('*', countTo79)}");
            Console.WriteLine($"80-89: {new String('*', countTo89)}");
            Console.WriteLine($"90-99: {new String('*', countTo99)}");
            Console.WriteLine($"100: {new String('*', count100)}");
            
            Console.ReadKey();
        }
    }
}
