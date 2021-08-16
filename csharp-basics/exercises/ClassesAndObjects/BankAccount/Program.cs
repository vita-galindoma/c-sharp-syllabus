using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount benben = new BankAccount("Benson", (decimal)17.25);
            BankAccount janjan = new BankAccount("Jan", (decimal)-17.5);

            benben.ShowUserNameAndBalance();
            janjan.ShowUserNameAndBalance();

            Console.ReadKey();
        }
    }
}
