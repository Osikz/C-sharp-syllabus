using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var benben = new BankAccount("Benson", 17.50M);
            var benneb = new BankAccount("Benson", -17.5431M);
            var nebben = new BankAccount("Benson", 55512.773M);

            Console.WriteLine(benben.ShowUserNameAndBalance());
            Console.WriteLine(benneb.ShowUserNameAndBalance());
            Console.WriteLine(nebben.ShowUserNameAndBalance());

            Console.ReadKey();
        }
    }
}
