using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Janis", "Zvirbulis", "Pils iela 31", 1);
            var student = new Student("Intars", "Ozols", "Raiņa bulvaris 101", 2, 7.5);
            var employee = new Employee("Viktors", "Berzins", "Maskavas iela 12", 3, "Kurjers");

            person.Display();
            student.Display();
            employee.Display();

            Console.ReadKey();
        }
    }
}