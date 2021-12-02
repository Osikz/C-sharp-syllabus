using System;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of minutes you want to convert to years and days:");

            long minutes = Convert.ToInt64(Console.ReadLine());
            long hours = minutes / 60;
            long day = hours / 24;
            long years = day / 365;
            long remainingDays = day % 365;

            if (minutes < 0)
            {
                Console.WriteLine("Invalid Value.");
            }
            else if (minutes < 525600)
            {
                Console.WriteLine($"{minutes} minutes is {remainingDays} days.");
            }
            else
            {
                Console.WriteLine($"{minutes} minutes is {years} years and {remainingDays} days.");
            }

            Console.ReadKey();
        }
    }
}
