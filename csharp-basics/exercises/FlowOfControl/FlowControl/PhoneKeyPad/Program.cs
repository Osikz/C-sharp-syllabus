using System;

namespace PhoneKeyPad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a text: ");
            var input = Console.ReadLine().ToLower().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    if (input[i] == 'a' || input[i] == 'b' || input[i] == 'c')
                    {
                        Console.Write(2);
                    }
                    else if (input[i] == 'd' || input[i] == 'e' || input[i] == 'f')
                    {
                        Console.Write(3);
                    }
                    else if (input[i] == 'g' || input[i] == 'h' || input[i] == 'i')
                    {
                        Console.Write(4);
                    }
                    else if (input[i] == 'j' || input[i] == 'k' || input[i] == 'l')
                    {
                        Console.Write(5);
                    }
                    else if (input[i] == 'm' || input[i] == 'n' || input[i] == 'o')
                    {
                        Console.Write(6);
                    }
                    else if (input[i] == 'p' || input[i] == 'q' || input[i] == 'r' || input[i] == 's')
                    {
                        Console.Write(7);
                    }
                    else if (input[i] == 't' || input[i] == 'u' || input[i] == 'v')
                    {
                        Console.Write(8);
                    }
                    else if (input[i] == 'w' || input[i] == 'x' || input[i] == 'y' || input[i] == 'z')
                    {
                        Console.Write(9);
                    }
                }
                else
                {
                    Console.Write(input[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
