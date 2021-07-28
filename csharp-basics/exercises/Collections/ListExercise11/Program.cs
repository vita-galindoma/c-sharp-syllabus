using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Create an List with string elements
            var products = new List<string>
            {
                "Apple",
                "Milk",
                "Cheese",
            };
            Console.WriteLine(string.Join(", ", products));
            Console.WriteLine();

            //TODO: Add 10 values to list
            products.Add("Bread");
            products.Add("Meat");
            products.Add("Cookies");
            products.Add("Bacon");
            products.Add("Oysters");
            products.Add("Cheese");
            products.Add("Grapes");
            products.Add("Banana");
            products.Add("Strawberry");
            products.Add("Potatoes");
            Console.WriteLine(string.Join(", ", products));
            Console.WriteLine();

            //TODO: Add new value at 5th position
            products.Insert(4, "Walnuts");
            Console.WriteLine(string.Join(", ", products));
            Console.WriteLine();

            //TODO: Change value at last position (Calculate last position programmatically)
            products[products.Count - 1] = "Tomato";
            Console.WriteLine(string.Join(", ", products));
            Console.WriteLine();

            //TODO: Sort your list in alphabetical order
            products.Sort();
            Console.WriteLine(string.Join(", ", products));
            Console.WriteLine();

            //TODO: Check if your list contains "Foobar" element
            Console.WriteLine(products.Contains("Foobar"));
            Console.WriteLine();
            
            //TODO: Print each element of list using loop
            foreach (var element in products)
            {
                Console.WriteLine(element);
            }
            
            Console.ReadKey();
        }
    }
}
