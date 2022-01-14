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

            Console.WriteLine(Methods.CheckNumber(numOne, numTwo));
            
            Console.ReadKey();
        }
    }
}
