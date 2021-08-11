using System;


namespace Persons
{
    public class Employee: Person
    {
        private string _jobTitle;
        public string JobTitle 
        {
            get => _jobTitle;
            set => _jobTitle = value;
        }

        public Employee(string firstName, string lastName, string address, int id)
        {
        }

        public Employee(string firstName, string lastName, string address, int id, string jobTitle) : base(firstName, lastName, address, id)
        {
            _jobTitle = jobTitle;
        }
        public override void Display()
        {
            Console.WriteLine($"First name: {FirstName} \nLast name: {LastName} \nAddress: {Address} \nID: {Id} \nJob title: {_jobTitle}\n");
        }
    }
}
