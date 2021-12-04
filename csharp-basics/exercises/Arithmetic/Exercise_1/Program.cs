using System;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            int.TryParse(Console.ReadLine(), out var numOne);
            Console.WriteLine("Please enter second number:");
            int.TryParse(Console.ReadLine(), out var numTwo);

            if (numOne == 15 || numTwo == 15)
            {
                Console.WriteLine("One of the entered numbers is 15.");
            }
            else if (numOne + numTwo == 15 || numOne - numTwo == 15 || numTwo - numOne == 15)
            {
                Console.WriteLine("The sum or difference of entered numbers is 15.");
            }
            else
            {
                Console.WriteLine("Neither of the entered numbers is 15. " +
                                  "Their sum or difference aren't 15.");
            }

            Console.ReadKey();
        }
    }
}
