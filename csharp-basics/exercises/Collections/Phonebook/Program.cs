using System;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new PhoneDirectory();

            phoneBook.PutNumber("Oskars", "27561234");
            phoneBook.PutNumber("Janis", "24890987");
            phoneBook.PutNumber("Viktors", "24545123");

            var janisNumber = phoneBook.GetNumber("Janis");
            var viktorsNumber = phoneBook.GetNumber("Viktors");

            Console.WriteLine($"Janis' number:{janisNumber}\r\nViktors' number:{viktorsNumber}");

            var nameByNumber = phoneBook.FindByNumber("27561234");
            Console.WriteLine($"27561234 owner is - {nameByNumber}");

            phoneBook.PutNumber("Anna", "23334512");

            phoneBook.DisplayPhoneBook();

            Console.ReadKey();
        }
    }
}
