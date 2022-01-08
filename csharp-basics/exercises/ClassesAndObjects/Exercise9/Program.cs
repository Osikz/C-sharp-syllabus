using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(5, 2);
            var p2 = new Point(-3, 6);

            SwapPoints(p1, p2);

            Console.WriteLine($"({p1.FirstPoint}, {p1.SecondPoint})");
            Console.WriteLine($"({p2.FirstPoint}, {p2.SecondPoint})");

            Console.ReadKey();
        }

        static void SwapPoints(Point p1, Point p2)
        {
            var x = p1.FirstPoint;
            var y = p1.SecondPoint;

            p1.FirstPoint = p2.FirstPoint;
            p1.SecondPoint = p2.SecondPoint;
            p2.FirstPoint = x;
            p2.SecondPoint = y;
        }
    }
}
