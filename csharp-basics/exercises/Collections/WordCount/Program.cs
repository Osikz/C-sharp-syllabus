using System;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\lear.txt");
            var list = lines.ToList();

            Console.WriteLine("The provided text file consists of:\r\n" +
                              $"Lines - {Methods.LineCounter(list)}\r\n" +
                              $"Words - {Methods.WordCounter(list)}\r\n" +
                              $"Chars - {Methods.LetterCounter(list)}");
            
            Console.ReadKey();
        }
    }
}
