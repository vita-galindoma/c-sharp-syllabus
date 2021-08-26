using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = new PhoneDirectory();
            Console.WriteLine("Add entries to Phone Book:");
            Console.WriteLine(directory.AddNumber("Tom", "4628308605"));
            Console.WriteLine(directory.AddNumber("Eric", "4628308608"));
            Console.WriteLine(directory.AddNumber("Elisa", "4629458608"));
            Console.WriteLine(directory.AddNumber("Elisa", "4629458608"));
            Console.WriteLine();
            
            Console.WriteLine("Phone Book");
            Console.WriteLine(directory.ReturnAllPhoneBook());
            Console.WriteLine();

            Console.WriteLine("Find by Name:");
            Console.WriteLine(directory.FindByName("Tom"));
            Console.WriteLine(directory.FindByName("Jacob"));
            Console.WriteLine();
            
            Console.WriteLine("Find by Number:");
            Console.WriteLine(directory.FindByNumber("4628308605"));
            Console.WriteLine(directory.FindByNumber("25496451213"));

            Console.ReadKey();
        }
    }
}
