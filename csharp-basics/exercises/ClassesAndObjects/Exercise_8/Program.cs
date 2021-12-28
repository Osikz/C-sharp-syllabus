using System;
using System.Globalization;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalDeposited = 0;
            decimal totalWithdrawn = 0;
            decimal interestEarned = 0;

            Console.WriteLine("How much money is in the account?:");
            var account = new SavingsAccount(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("Enter the annual interest rate:");
            account.AnnualInterestRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How long has the account been opened?:");
            var months = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= months; i++)
            {
                int amount;

                Console.WriteLine($"Enter amount deposited for month {i}:");
                amount = Convert.ToInt32(Console.ReadLine());
                account.Deposit(amount);
                totalDeposited += amount;

                Console.WriteLine($"Enter amount withdrawn for month {i}:");
                amount = Convert.ToInt32(Console.ReadLine());
                account.Withdrawal(amount);
                totalWithdrawn += amount;

                interestEarned += account.MonthlyInterestRate();
                
            }

            Console.WriteLine($"Total deposited: {totalDeposited.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}\r\n" +
                              $"Total withdrawn: {totalWithdrawn.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}\r\n" +
                              $"Interest earned: {interestEarned.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}\r\n" +
                              $"Ending balance: {account.GetBalance().ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
        }
    }
}
