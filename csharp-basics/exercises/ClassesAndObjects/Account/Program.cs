using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            // YOUR FIRST ACCOUNT
            var firstAccount = new Account("First account", 100D);
            firstAccount.Deposit(20D);

            Console.WriteLine(firstAccount.ToString());

            // YOUR FIRST MONEY TRANSFER
            var mattAccount = new Account("Matt's account", 1000D);
            var myAccount = new Account("My account", 0D);
            mattAccount.Withdrawal(100D);
            myAccount.Deposit(100D);

            Console.WriteLine(mattAccount.ToString());
            Console.WriteLine(myAccount.ToString());

            // MONEY TRANSFERS
            var accA = new Account("A's account", 100D);
            var accB = new Account("B's account", 0D);
            var accC = new Account("C's account", 0D);

            Transfer(accA, accB, 50D);
            Transfer(accB, accC, 25D);

            Console.WriteLine(accA.ToString());
            Console.WriteLine(accB.ToString());
            Console.WriteLine(accC.ToString());

            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }
    }
}
