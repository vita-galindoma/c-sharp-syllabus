using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        private string _name;
        private decimal _balance;

        public BankAccount(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        public void ShowUserNameAndBalance()
        {
            if (_balance < 0)
            {
                _balance = Math.Abs(_balance);
                Console.WriteLine($"{_name}, -${_balance.ToString("N")}");
            }
            else
            {
                Console.WriteLine($"{_name}, ${_balance.ToString("N")}");
            }
        }
    }
}
