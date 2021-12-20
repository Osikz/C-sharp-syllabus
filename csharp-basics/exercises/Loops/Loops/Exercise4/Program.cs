﻿using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            Console.WriteLine("Using for:");
            for (int i = 0; i < vowels.Length; i++) 
            {
                Console.WriteLine(vowels[i]);
            }

            Console.WriteLine("Using foreach:");
            foreach (char vowel in vowels) 
            {
                Console.WriteLine(vowel);
            }

            Console.ReadKey();
        }
    }
}
