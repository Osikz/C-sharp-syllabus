using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 1 to 20 to get a number in that position: ");
            int input = Convert.ToInt32(Console.ReadLine());
            var rnd = new Random();

            while (input > 20 || input < 1)
            {
                Console.WriteLine("Please enter correct number from 1 to 20: ");
                input = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 20; i++)
            {
                var number = rnd.Next(0, 99999);
                if (i == input - 1)
                {
                    Console.WriteLine($"The number in position {input} is {number}!");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
