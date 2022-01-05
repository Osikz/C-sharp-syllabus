using System;
using System.Collections.Generic;
using System.IO;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            var list = new List<int>();
            var count = new int[11];
            var startRange = 0;
            var endRange = 9;
            
            foreach (var s in readText)
            {
                var arr = s.Split(' ');
                for (int i = 0; i < arr.Length; i++)
                {
                    list.Add(Convert.ToInt32(arr[i]));
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                switch (list)
                {
                    case var n when n[i] > 0 && n[i] < 10:
                        count[0]++;
                        break;
                    case var n when n[i] >= 10 && n[i] < 20:
                        count[1]++;
                        break;
                    case var n when n[i] >= 20 && n[i] < 30:
                        count[2]++;
                        break;
                    case var n when n[i] >= 30 && n[i] < 40:
                        count[3]++;
                        break;
                    case var n when n[i] >= 40 && n[i] < 50:
                        count[4]++;
                        break;
                    case var n when n[i] >= 50 && n[i] < 60:
                        count[5]++;
                        break;
                    case var n when n[i] >= 60 && n[i] < 70:
                        count[6]++;
                        break;
                    case var n when n[i] >= 70 && n[i] < 80:
                        count[7]++;
                        break;
                    case var n when n[i] >= 80 && n[i] < 90:
                        count[8]++;
                        break;
                    case var n when n[i] >= 90 && n[i] < 100:
                        count[9]++;
                        break;
                    case var n when n[i] == 100:
                        count[10]++;
                        break;
                }
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (startRange == 100)
                {
                    Console.Write($"  {startRange}:");
                }
                else if (startRange == 0)
                {
                    Console.Write($"{startRange}0-0{endRange}:");
                }
                else
                {
                    Console.Write($"{startRange}-{endRange}:");
                }
               
                for (int j = 0; j < count[i]; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                startRange += 10;
                endRange += 10;
            }
            
            Console.ReadKey();
        }
    }
}
