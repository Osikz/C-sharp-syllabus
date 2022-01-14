using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrOne = new int[10];
            var arrTwo = new int[10];
            var rnd = new Random();

            ArrayMethods.RandomArrayNumbers(rnd, arrOne, arrTwo);
            ArrayMethods.ChangeLastNumber(arrTwo);
            
            Console.Write("Array 1: ");
            for (int i = 0; i < arrOne.Length; i++)
            {
                Console.Write($"{arrOne[i]} ");
            }

            Console.Write("\r\nArray 2: ");
            for (int i = 0; i < arrTwo.Length; i++)
            {
                Console.Write($"{arrTwo[i]} ");
            }

            Console.ReadKey();
        }

    }
}
