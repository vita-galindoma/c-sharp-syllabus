using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            Console.WriteLine("Array:");
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine();

            //todo - replace array with an List and print out the results
            var list = new List<string> {"Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla"};
            Console.WriteLine("List:");
            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine();

            //todo - replace array with a HashSet and print out the results
            var hashset = new HashSet<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            Console.WriteLine("Hashset:");
            Console.WriteLine(string.Join(", ", hashset));
            Console.WriteLine();

            //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("Audi", "Germany");
            dictionary.Add("BMW", "Germany");
            dictionary.Add("Honda", "Japan");
            dictionary.Add("Mercedes", "Germany");
            dictionary.Add("VolksWagen", "Germany");
            dictionary.Add("Tesla", "USA");

            Console.WriteLine("Dictionary:");
            
            foreach (var element in dictionary)
            {
                Console.WriteLine($"{element.Key} => {element.Value}");
            }

            Console.ReadKey();
        }
    }
}
