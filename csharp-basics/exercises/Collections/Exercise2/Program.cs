using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var mySet = new HashSet<string>();
            var name = string.Empty;
            do
            {
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                mySet.Add(name);
            } while (name != string.Empty);

            Console.WriteLine($"Unique name list contains: {string.Join(" ", mySet)}"); 
            Console.ReadKey();
        }
    }
}
