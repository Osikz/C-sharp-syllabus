using System;

namespace CozaLozaWoza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lastNum = 110;

            for (int i = 1; i <= lastNum; i++)
            {
                if (i % 11 == 1)
                {
                    Console.WriteLine();
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("CozaLoza");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Woza");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Loza");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Coza");
                }
                else
                {
                    Console.Write($"{i}");
                }
            }

            Console.ReadKey();
        }
    }
}