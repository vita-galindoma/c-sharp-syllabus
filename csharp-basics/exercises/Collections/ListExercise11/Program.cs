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

            products.Insert(4, "Walnuts");
            Console.WriteLine(string.Join(", ", products));
            Console.WriteLine();

            products[products.Count - 1] = "Tomato";
            Console.WriteLine(string.Join(", ", products));
            Console.WriteLine();

            products.Sort();
            Console.WriteLine(string.Join(", ", products));
            Console.WriteLine();

            Console.WriteLine(products.Contains("Foobar"));
            Console.WriteLine();
            
            foreach (var element in products)
            {
                Console.WriteLine(element);
            }
            
            Console.ReadKey();
        }
    }
}
