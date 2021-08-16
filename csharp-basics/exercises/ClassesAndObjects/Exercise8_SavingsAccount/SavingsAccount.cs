using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_SavingsAccount
{
    class SavingsAccount
    {
        private decimal _annualInterestRate;
        private decimal _balance;
        private decimal _totalDeposit;
        private decimal _totalWithdrawal;
        private decimal _totalAmountOfMonthlyInterest;

        public SavingsAccount(decimal balance, decimal annualInterestRate)
        {
            _balance = balance;
            _annualInterestRate = annualInterestRate;
        }

        public void Withdrawal(decimal amnt)
        {
            _balance -= amnt;
            _totalWithdrawal += amnt;
        }

        public void AddingToDeposit(decimal amnt)
        {
            _balance += amnt;
            _totalDeposit += amnt;
        }

        public decimal AddingMonthlyInterest(decimal annualInterestRate)
        {
            var monthlyInt =  _annualInterestRate / 12 * _balance;
            _balance += monthlyInt;
            _totalAmountOfMonthlyInterest += monthlyInt;
            return monthlyInt;
        }

        public decimal TotalDeposit()
        {
            return _totalDeposit;
        }

        public decimal TotalWithdrawal()
        {
            return _totalWithdrawal;
        }
        public decimal TotalInterestEarned()
        {
            return _totalAmountOfMonthlyInterest;
        }
        public decimal EndingBalance()
        {
            return _balance;
        }
    }
}
