using System;
using System.Collections.Generic;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            var input = Convert.ToInt32(Console.ReadLine());
            var happy = new List<int>();
            var sum = 0D;
            var iterations = 0;

            for (int i = 0; i < input.ToString().Length; i++)
            {
                happy.Add(input.ToString()[i] - 48);
            }

            while (iterations < 50)
            {
                for (int i = 0; i < happy.Count; i++)
                {
                    sum += Math.Pow(happy[i], 2);
                }

                happy.Clear();
                for (int i = 0; i < sum.ToString().Length; i++)
                {
                    happy.Add(sum.ToString()[i] - 48);
                }

                if (sum == 1)
                {
                    Console.WriteLine($"{input} is happy! :)");
                    break;
                }

                sum = 0;
                iterations++;
            }

            if (sum != 1)
            {
                Console.WriteLine($"{input} is not happy! :(");
            }

            Console.ReadKey();
        }
    }
}
