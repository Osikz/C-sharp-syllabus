using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            string[] classes = 
            {
                "English III", 
                "Precalculus", 
                "Music Theory", 
                "Biotechnology", 
                "Principles of Technology I", 
                "Latin II", 
                "AP US History", 
                "Business Computer Information Systems"
            };

            string[] teachers = 
            {
                "Ms. Lapan", 
                "Mrs. Gideon", 
                "Mr. Davis", 
                "Ms. Palmer", 
                "Ms. Garcia", 
                "Mrs.Barnett", 
                "Ms. Johannessen", 
                "Mr. James"

            };

            static void TableSeperator()
            {
                Console.Write("+");

                for (int i = 0; i < 61; i++)
                {
                    Console.Write("-");
                }

                Console.WriteLine("+");
            }

            TableSeperator();
            Console.WriteLine($"| 1 |{classes[0].PadLeft(38)} |{teachers[0].PadLeft(16)} |");
            Console.WriteLine($"| 2 |{classes[1].PadLeft(38)} |{teachers[1].PadLeft(16)} |");
            Console.WriteLine($"| 3 |{classes[2].PadLeft(38)} |{teachers[2].PadLeft(16)} |");
            Console.WriteLine($"| 4 |{classes[3].PadLeft(38)} |{teachers[3].PadLeft(16)} |");
            Console.WriteLine($"| 5 |{classes[4].PadLeft(38)} |{teachers[4].PadLeft(16)} |");
            Console.WriteLine($"| 6 |{classes[5].PadLeft(38)} |{teachers[5].PadLeft(16)} |");
            Console.WriteLine($"| 7 |{classes[6].PadLeft(38)} |{teachers[6].PadLeft(16)} |");
            Console.WriteLine($"| 8 |{classes[7].PadLeft(38)} |{teachers[7].PadLeft(16)} |");
            TableSeperator();

            Console.ReadKey();
        }
    }
}