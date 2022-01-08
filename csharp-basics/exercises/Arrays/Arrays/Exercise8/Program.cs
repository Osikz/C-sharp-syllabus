using System;
using System.Text;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game();

            while (PlayAgain())
            {
                Game();
            }
            Environment.Exit(0);

            Console.ReadKey();
        }

        public static void Game()
        {
            string[] words = { "exercise", "Codelex", "monday", "syllabus", "presentation", "network", "Apple", "arrays" };
            var rnd = new Random();
            var word = words[rnd.Next(0, words.Length)].ToLower();
            var guessable = new string('_', word.Length);
            var misses = string.Empty;
            Board(guessable, misses, ' ');

            while (guessable.IndexOf('_') != -1)
            {
                var input = Console.ReadKey();
                var guess = input.KeyChar;

                if (WordContains(word, guess))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == guess)
                        {
                            var sb = new StringBuilder(guessable);
                            sb[i] = word[i];
                            guessable = sb.ToString();
                        }
                    }
                }
                else
                {
                    misses += guess;
                }

                Board(guessable, misses, guess);

                if (misses.Length >= 5)
                {
                    Console.WriteLine("You didn't guess the word.");
                    break;
                }
            }
        }
        public static bool WordContains(string word, char guess)
        {
            return word.ToLower().IndexOf(guess) > -1;
        }

        public static void Board(string guessable, string misses, char guess)
        {
            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($"Word: {guessable}");
            Console.WriteLine($"Misses: {misses}");
            Console.WriteLine($"Guess: {guess}");
        }

        public static bool PlayAgain()
        {
            Console.WriteLine("\r\nWant to play again?" +
                "\r\nPress 'y' or 'n'");

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
