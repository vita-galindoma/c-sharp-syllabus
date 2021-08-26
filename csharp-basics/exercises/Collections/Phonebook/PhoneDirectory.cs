using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        SortedDictionary<string, string> phoneBook =
            new SortedDictionary<string, string>();
        

        public string AddNumber (string name, string number)
        {
            try
            {
                phoneBook.Add(name, number);
                return "Added.";
            }
            catch (ArgumentException)
            {
                return $"An entry with name {name} already exists.";
            }
        }

        public string FindByName(string name)
        {
            if (phoneBook.ContainsKey(name))
            {
                return $"name: {name}, number: {phoneBook[name]}.";
            }
            else
            {
                return $"{name} is not found.";
            }
        }

        public string FindByNumber(string number)
        {
            var key = phoneBook.Where(kvp => kvp.Value == number).Select(kvp => kvp.Key).FirstOrDefault();
            if (phoneBook.ContainsValue(number))
            {
                return $"This {number} belongs to {key}.";
            }
            else
            { 
                return $"Number {number} is not found.";
            }
        }

        public string ReturnAllPhoneBook()
        {
            string phoneBookEntries = String.Empty;
            foreach (KeyValuePair<string, string> item in phoneBook)
            {
                phoneBookEntries += $"Name: {item.Key}, Number: {item.Value}\n";
            }

            return phoneBookEntries;
        }
    }
}