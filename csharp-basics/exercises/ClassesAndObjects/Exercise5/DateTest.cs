using System;

namespace Exercise5
{
    public class DateTest
    {
        static void Main(string[] args)
        {
            var date = new Date(31, 12, 2021);
            var date1 = new Date(24, 12, 2021);
            var date2 = new Date(01, 01, 2022);

            Console.WriteLine(date.DisplayDate());
            Console.WriteLine(date1.DisplayDate());
            Console.WriteLine(date2.DisplayDate());

            Console.ReadKey();
        }
    }
}
