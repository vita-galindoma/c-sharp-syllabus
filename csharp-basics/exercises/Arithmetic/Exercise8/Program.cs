using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculation1 = new Exercise8Extension(7.5, 35);
            var calculation2 = new Exercise8Extension(8.2, 47);
            var calculation3 = new Exercise8Extension(10, 73);
            Console.WriteLine(calculation1.WageCalculator());
            Console.WriteLine(calculation2.WageCalculator());
            Console.WriteLine(calculation3.WageCalculator());

            Console.ReadKey();
        }
    }
}
