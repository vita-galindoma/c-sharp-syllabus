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
            directory.AddNumber("Tom", "4628308605");
            directory.AddNumber("Eric", "4628308608");
            directory.AddNumber("Elisa", "4629458608");
            directory.AddNumber("Elisa", "4629458608");
            Console.WriteLine();
            
            Console.WriteLine("Phone Book");
            directory.GetAllPhoneBook();
            Console.WriteLine();

            Console.WriteLine("Find by Name:");
            directory.FindByName("Tom");
            directory.FindByName("Jacob");
            Console.WriteLine();
            
            Console.WriteLine("Find by Number:");
            directory.FindByNumber("4628308605");
            directory.FindByNumber("25496451213");

            Console.ReadKey();
        }
    }
}
