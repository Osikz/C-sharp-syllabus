using System;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatePay(7.50, 35);
            CalculatePay(8.20, 47);
            CalculatePay(10.00, 73);

            Console.ReadKey();
        }

        static void CalculatePay(double payRate, int hours)
        {
            if (payRate < 8.00 || hours > 60)
            {
                Console.WriteLine("Something is not right here...");
            }
            else if (hours <= 40)
            {
                Console.WriteLine($"Employee earned {Math.Round(payRate * hours, 2)}$ this week.");
            }
            else if (hours > 40)
            {
                int overtime = hours - 40;
                double overtimePayRate = payRate * 1.5;
                Console.WriteLine($"Employee earned {Math.Round(payRate * 40 + overtime * overtimePayRate, 2)}$ this week.");
            }
        }
    }
}
