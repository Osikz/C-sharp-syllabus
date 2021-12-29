using System;
using System.Globalization;

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

    class BankAccount
    {
        private string _name;
        private decimal _balance;

        public BankAccount(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            if (_balance < 0)
            {
                _balance *= -1;
                return $"{_name}, -{_balance.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}";
            }
            return $"{_name},  {_balance.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}";
        }
    }
}
