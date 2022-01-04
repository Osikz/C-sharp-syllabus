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
            var words = 0;
            var chars = 0;

            foreach (var line in list)
            {
                var charArray = line.ToCharArray();
                chars += charArray.Length;
                var word = line.Split(' ');
                words += word.Length;
            }

            Console.WriteLine("The provided text file consists of:\r\n" +
                              $"Lines - {list.Count}\r\n" +
                              $"Words - {words}\r\n" +
                              $"Chars - {chars}");
            
            Console.ReadKey();
        }
    }
}
