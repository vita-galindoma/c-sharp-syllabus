using System;
using System.Transactions;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = new Exercise2Extension(30);
            var result = inputNumber.CheckOdd();
            Console.WriteLine(result == true ? "Even number" : "Odd number");
            Console.WriteLine("Bye!");
        }
    }
}
