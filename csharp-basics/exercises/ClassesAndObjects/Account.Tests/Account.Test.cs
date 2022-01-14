using NUnit.Framework;

namespace Account.Tests
{
    public class Tests
    {
        private Account _target;
        [SetUp]
        public void Setup()
        {
            _target = new Account("John's Account", 1000D);
        }

        [Test]
        public void Withdrawal_AmountToWithdraw_ShouldReturnAmountAfterWithdrawal()
        {
            //Act
            var amount = 200;

            //Assert
            Assert.AreEqual(_target.Withdrawal(amount), _target.Balance());
        }

        [Test]
        public void Deposit_AmountToDeposit_ShouldReturnAmountAfterDeposit()
        {
            //Act
            var amount = 200;

            //Assert
            Assert.AreEqual(_target.Deposit(amount), _target.Balance());
        }

        [Test]
        public void Balance_AccountToDisplayBalance_ShouldDisplayCorrectBalance()
        {
            //Arrange
            var name = "Peteris' Account";
            var money = 500D;
            
            //Act
            _target = new Account(name, money);

            //Assert
            Assert.AreEqual(_target.Balance(), money);
        }

        [Test]
        public void ToString_AccountToDisplay_ShouldDisplayCorrectly()
        {
            //Arrange
            var name = "Peteris' Account";
            var money = 500D;

            //Act
            _target = new Account(name, money);

            //Assert
            Assert.AreEqual(_target.ToString(), $"{name}: {money}");
        }
    }
}