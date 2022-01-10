namespace Exercise_8
{
    internal class SavingsAccount
    {
        private decimal _balance;

        public decimal AnnualInterestRate { get; set; }

        public SavingsAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }

        public decimal Withdrawal(int amount)
        {
            return _balance -= amount;
        }

        public decimal Deposit(int amount)
        {
            return _balance += amount;
        }

        public decimal MonthlyInterestRate()
        {
            var monthlyInterestRate = AnnualInterestRate / 12;
            var oldBalance = _balance;
            _balance += monthlyInterestRate * oldBalance;
            return monthlyInterestRate * oldBalance;
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}
