using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logitech = new Product("Logitech Mouse", 69.99d, 10);
            var steelseries = new Product("Steelseries Mouse", 59.99d, 15);
            var zowie = new Product("Zowie Mouse", 99.99d, 7);

            Console.WriteLine("Product list:\r\n");

            logitech.PrintProduct();
            steelseries.PrintProduct();
            zowie.PrintProduct();

            logitech.ChangeAmount(6);
            logitech.ChangePrice(79.99d);
            zowie.ChangeAmount(2);
            steelseries.ChangePrice(49.99d);
            steelseries.ChangeAmount(13);

            Console.WriteLine("\r\nProduct list after changes:\r\n");

            logitech.PrintProduct();
            steelseries.PrintProduct();
            zowie.PrintProduct();

            Console.ReadKey();
        }
    }
}
