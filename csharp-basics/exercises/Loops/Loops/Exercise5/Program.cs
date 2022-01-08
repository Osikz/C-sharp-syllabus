using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            var firstWord = Console.ReadLine();
            Console.WriteLine("Enter second word:");
            var secondWord = Console.ReadLine();

            Console.Write(firstWord);

            for (int i = 0; i < 30 - firstWord.Length - secondWord.Length; i++)
            {
                Console.Write(".");
            }

            Console.Write(secondWord);

            Console.ReadKey();
        }
    }
}
