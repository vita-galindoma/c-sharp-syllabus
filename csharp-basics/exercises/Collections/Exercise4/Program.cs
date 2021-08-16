using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            SumDigitSquare(n);

            int result = SumDigitSquare(n);
            while (result.ToString().Length != 1)
            {
                result = SumDigitSquare(result);
            }
            Console.WriteLine(result == 1 ? $"{n} is happy" : $"{n} is not Happy");

            Console.ReadKey();
        }

        static int SumDigitSquare(int n)
        {
            int sqSum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sqSum += digit * digit;
                n = n / 10;
            }
            return sqSum;
        }
    }
}
