using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        SortedDictionary<string, string> phoneBook =
            new SortedDictionary<string, string>();


        public void AddNumber (string name, string number)
        {
            try
            {
                phoneBook.Add(name, number);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"An entry with name {name} already exists.");
            }
        }

        public void FindByName(string name)
        {
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine($"name: {name}, number: {phoneBook[name]}.");
            }
            else
            {
                Console.WriteLine($"{name} is not found.");
            }
        }

        public void FindByNumber(string number)
        {
            var key = phoneBook.Where(kvp => kvp.Value == number).Select(kvp => kvp.Key).FirstOrDefault();
            if (phoneBook.ContainsValue(number))
            {
                Console.WriteLine($"This {number} belongs to {key}.");
            }
            else
            { 
                Console.WriteLine($"Number {number} is not found.");
            }
        }

        public void GetAllPhoneBook()
        {
            foreach (KeyValuePair<string, string> kvp in phoneBook)
            {
                Console.WriteLine("Name: {0}, Number: {1}",
                    kvp.Key, kvp.Value);
            }
        }
    }
}