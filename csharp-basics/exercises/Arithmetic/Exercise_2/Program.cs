using System;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int.TryParse(Console.ReadLine(), out int number);

            Console.WriteLine(number % 2 == 0 ? $"{number} is Even Number" : $"{number} is Odd Number");
            Console.WriteLine("\r\nBye!");
        }
    }
}