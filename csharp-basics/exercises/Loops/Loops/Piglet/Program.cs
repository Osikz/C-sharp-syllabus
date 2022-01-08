using System;

namespace Piglet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var dice = rnd.Next(1, 7);
            int sum = dice;

            Console.WriteLine("Welcome to Piglet!");
            Console.WriteLine($"You rolled {dice}!");

            while (RollAgain())
            {
                dice = rnd.Next(1, 7);

                Console.WriteLine();
                Console.WriteLine($"You rolled {dice}!");
                sum += dice;

                if (dice == 1)
                {
                    sum = 0;
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"You got {sum} points!");
        }

        public static bool RollAgain()
        {
            Console.WriteLine("Roll again?");
            var input = Console.ReadKey();

            if (input.KeyChar == 'y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
