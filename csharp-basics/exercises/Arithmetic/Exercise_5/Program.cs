using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(1, 101);

            Console.WriteLine("I'm thinking of a number between 1-100. Try to guess it.");
            int.TryParse(Console.ReadLine(), out int guess);

            if (guess == randomNum)
            {
                Console.WriteLine("You guessed it! What are the odds?!?");
            }
            else if (guess > randomNum)
            {
                Console.WriteLine($"Sorry, you are too high. I was thinking of {randomNum}.");
            }
            else
            {
                Console.WriteLine($"Sorry, you are too low. I was thinking of {randomNum}.");
            }

            Console.ReadKey();
        }
    }
}