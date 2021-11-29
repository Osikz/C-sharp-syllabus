using System;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text to receive uppercase letter count:");

            string userInput = Console.ReadLine();
            int upperLetters = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (char.IsUpper(userInput[i]))
                {
                    upperLetters++;
                }
            }

            Console.WriteLine($"There are {upperLetters} uppercase letters in provided text.");
            Console.ReadKey();
        }
    }
}
