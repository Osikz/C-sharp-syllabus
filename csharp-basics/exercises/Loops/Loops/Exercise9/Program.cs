using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            Console.WriteLine("Please enter desired sum of two dices (2-12):");

            while (int.TryParse(Console.ReadLine(), out int sum))
            {
                if (sum <= 12 && sum >= 2)
                {
                    Console.WriteLine($"Desired sum: {sum}");
                    for (int i = 0; ; i++)
                    {
                        var dice1 = rnd.Next(1, 7);
                        var dice2 = rnd.Next(1, 7);
                        var diceRoll = dice1 + dice2;

                        if (diceRoll == sum)
                        {
                            Console.WriteLine($"{dice1} and {dice2} = {sum}");
                            Console.WriteLine("Enter desired sum(2-12) if you want to roll again:");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{dice1} and {dice2} = {diceRoll}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter correct sum 2-12:");
                }
            }
            
            Console.ReadKey();
        }
    }
}
