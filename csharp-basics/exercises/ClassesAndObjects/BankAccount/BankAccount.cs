using System.Globalization;

namespace BankAccount
{
    public class BankAccount
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
