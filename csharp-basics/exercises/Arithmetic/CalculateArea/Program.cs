using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var userChoice = GetMenu();

            if (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("\r\nPlease enter correct number:");
                GetMenu();
            }
            else
            {
                switch (userChoice)
                {
                    case 1:
                        CalculateCircleArea();
                        break;
                    case 2:
                        CalculateRectangleArea();
                        break;
                    case 3:
                        CalculateTriangleArea();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }

            Console.ReadKey();
        }

        public static int GetMenu()
        {
            int userChoice = 0;

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey().KeyChar.ToString();

            switch (keyboard)
            {
                case "1":
                    userChoice = 1;
                    break;
                case "2":
                    userChoice = 2;
                    break;
                case "3":
                    userChoice = 3;
                    break;
                case "4":
                    userChoice = 4;
                    break;
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("\r\nWhat is the circle's radius? ");
            decimal.TryParse(Console.ReadLine(), out decimal radius);
            
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            Console.WriteLine("\r\nEnter length: ");
            decimal.TryParse(Console.ReadLine(), out decimal length);
            
            Console.WriteLine("Enter width: ");
            decimal.TryParse(Console.ReadLine(), out decimal width);

            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            Console.WriteLine("\r\nEnter length of the triangle's base: ");
            decimal.TryParse(Console.ReadLine(), out decimal ground);

            Console.WriteLine("Enter triangle's height: ");
            decimal.TryParse(Console.ReadLine(), out decimal height);

            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}
