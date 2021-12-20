using System;

namespace AsciiFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter desired size:");
            var input = Convert.ToInt32(Console.ReadLine());

            for (int i = input; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write("////");
                }
                for (int e = input; e > i; e--)
                {
                    Console.Write("********");
                }
                for (int k = 0; k < i - 1; k++)
                {
                    Console.Write("\\\\\\\\");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
