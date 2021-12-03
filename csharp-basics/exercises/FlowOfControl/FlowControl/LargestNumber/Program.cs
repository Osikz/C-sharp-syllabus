using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            int.TryParse(Console.ReadLine(), out int input1);

            Console.WriteLine("Input the 2nd number: ");
            int.TryParse(Console.ReadLine(), out int input2);

            Console.WriteLine("Input the 3rd number: ");
            int.TryParse(Console.ReadLine(), out int input3);

            if (input1 > input2 && input1 > input3)
            {
                Console.WriteLine($"1st number is the largest - {input1}.");
            }
            else if (input2 > input1 && input2 > input3)
            {
                Console.WriteLine($"2nd number is the largest - {input2}.");
            }
            else
            {
                Console.WriteLine($"3rd number is the largest - {input3}.");
            }

            Console.ReadKey();
        }
    }
}
