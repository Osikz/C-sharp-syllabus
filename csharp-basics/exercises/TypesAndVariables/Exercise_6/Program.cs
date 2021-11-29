using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[6];
            int sum = 0;

            Console.WriteLine($"Enter {digits.Length} digits to receive their sum:");

            for (int i = 0; i < digits.Length; i++)
            {
                var userInput = Console.ReadKey();

                if (char.IsDigit(userInput.KeyChar))
                {
                    digits[i] = int.Parse(userInput.KeyChar.ToString());
                }
                else
                {
                    digits[i] = 0;
                }
            }


            foreach (int digit in digits)
            {
                sum += digit;
            }

            Console.WriteLine();
            Console.WriteLine($"The sum of entered digits is: {sum}");

        }
    }
}
