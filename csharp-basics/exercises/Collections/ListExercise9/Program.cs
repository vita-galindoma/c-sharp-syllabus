using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(", ", firstList));

            var secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(", ", secondList));
            //TODO: Write a C# program to join two lists.

            //option 1 - creating new list
            var newList = firstList.Concat(secondList);
            Console.WriteLine(string.Join(", ", newList));

            //option 2 - adding one list to another
            firstList.AddRange(secondList);
            Console.WriteLine(string.Join(", ", firstList));
            
            Console.ReadKey();
        }
    }
}
