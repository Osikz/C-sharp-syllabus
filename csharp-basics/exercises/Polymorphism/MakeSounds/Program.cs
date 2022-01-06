using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var soundList = new List<ISound> {new Firework(), new Parrot(), new Radio()};

            foreach (var sound in soundList)
            {
                sound.PlaySound();
            }

            Console.ReadKey();
        }
    }
}