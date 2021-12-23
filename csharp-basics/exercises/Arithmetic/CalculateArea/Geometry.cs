using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            if (radius <= 0)
            {
                throw new InvalidOperationException("ERROR! Can't calculate negative values.");
            }
            else
            {
                decimal areaCircle = Math.Round((decimal)Math.PI * radius * 2, 2);
                return (double)areaCircle;
            }
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new InvalidOperationException("ERROR! Can't calculate negative values.");
            }
            else
            {
                decimal areaRectangle = Math.Round(length * width, 2);
                return (double)areaRectangle;
            }
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            if (ground <= 0 || h <= 0)
            {
                throw new InvalidOperationException("ERROR! Can't calculate negative values.");
            }
            else
            {
                double areaTriangle = Math.Round((double)ground * (double)h * 0.5, 2);
                return areaTriangle;
            }
        }
    }
}
