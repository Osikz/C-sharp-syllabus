using System;
using System.Linq;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = new int[10];
            int[] arrTwo = new int[10];
            var rnd = new Random();

            for (int i = 0; i < arrOne.Length; i++)
            {
                arrOne[i] = rnd.Next(1, 101);
            }
            
            Array.Copy(arrOne, arrTwo, arrOne.Length);

            arrOne[^1] = -7;

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
