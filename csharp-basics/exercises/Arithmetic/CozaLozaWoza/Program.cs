using System;

namespace CozaLozaWoza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lastNum = 110;
            int i;

            for (i = 1; i <= lastNum; i++)
            {
                Console.Write(Methods.CheckForCozaWozaLoza(i));
            }

            Console.ReadKey();
        }
    }
}