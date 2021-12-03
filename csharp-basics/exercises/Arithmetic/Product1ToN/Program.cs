using System;

namespace Product1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int product = 1;

            Console.WriteLine("Please enter the end point of product: ");
            int.TryParse(Console.ReadLine(), out int end);

            for (int i = start; i <= end; i++)
            {
                product *= i;
            }

            Console.WriteLine($"The product from {start} to {end} is {product}.");
            Console.ReadKey();
        }
    }
}
