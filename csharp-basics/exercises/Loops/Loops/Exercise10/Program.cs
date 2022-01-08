using System;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter MIN value:");
            int.TryParse(Console.ReadLine(), out int min);
            Console.WriteLine("Enter MAX value:");
            int.TryParse(Console.ReadLine(), out int max);

            for (int i = min; i <= max; i++)
            {
                Console.Write(i);
                var increment = i;

                for (int j = min; j < max; j++)
                {
                    increment++;

                    if (increment > max)
                    {
                        increment = min;
                        Console.Write(increment);
                    }
                    else
                    {
                        Console.Write(increment);
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
