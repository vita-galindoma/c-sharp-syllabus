using System;

namespace Exercise8_SavingsAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money is in the account?");
            decimal startingBalance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the annual interest rate:");
            decimal annualIntRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("How long has the account been opened?");
            decimal monthsEstablished = Convert.ToDecimal(Console.ReadLine());

            SavingsAccount account = new SavingsAccount(startingBalance, annualIntRate);

            for (int i = 1; i <= monthsEstablished; i++)
            {
                Console.Write($"Enter amount deposited for month: {i}: ");
                decimal deposit = Convert.ToDecimal(Console.ReadLine());
                account.AddingToDeposit(deposit);

                Console.Write($"Enter amount withdrawn for: {i}: ");
                decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                account.Withdrawal(withdraw);

                account.AddingMonthlyInterest(annualIntRate);
            }

            Console.WriteLine($"Total deposited: ${account.TotalDeposit().ToString("N")}");
            Console.WriteLine($"Total withdrawn: ${account.TotalWithdrawal().ToString("N")}");
            Console.WriteLine($"Interest earned: ${account.TotalInterestEarned().ToString("N")}");
            Console.WriteLine($"Ending balance: ${account.EndingBalance().ToString("N")}");

            Console.ReadKey();
        }
    }
}
