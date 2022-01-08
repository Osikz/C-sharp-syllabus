using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, baseNum, sum;
            
            Console.WriteLine("Input number to power : ");
            baseNum = Convert.ToInt32(Console.ReadLine());
            sum = baseNum;

            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(sum *= baseNum);

            }
            
            Console.ReadKey();
        }
    }
}
