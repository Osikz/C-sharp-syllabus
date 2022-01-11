using System;
using NUnit.Framework;
using PhoneBook;

namespace Phonebook.Tests
{
    public class Tests
    {
        private PhoneDirectory _target;
        [SetUp]
        public void Setup()
        {
            _target = new PhoneDirectory();
            _target.PutNumber("Oskars", "27561234");
            _target.PutNumber("Janis", "24890987");
            _target.PutNumber("Viktors", "24545123");
        }

        [Test]
        public void FindByNumber_24890987_Janis()
        {
            //Arrange, Act
            var janis = _target.FindByNumber("24890987");
            
            //Assert
            Assert.AreEqual(janis, "Janis");
        }

        [Test]
        public void FindByNumber_47174156_StringEmpty()
        {
            //Arrange, Act
            var janis = _target.FindByNumber("47174156");

            //Assert
            Assert.AreEqual(janis, string.Empty);
        }

        [Test]
        public void GetNumber_Oskars_27561234()
        {
            //Arrange, Act
            var oskars = _target.GetNumber("Oskars");

            //Assert
            Assert.AreEqual(oskars, "27561234");
        }

        [Test]
        public void GetNumber_Visvaldis_StringEmpty()
        {
            //Arrange, Act
            var visvaldis = _target.GetNumber("Visvaldis");

            //Assert
            Assert.AreEqual(visvaldis, string.Empty);
        }

        [TestCase("Vasilijs", null)]
        [TestCase(null, "25123456")]
        [TestCase(null, null)]
        public void PutNumber_Null_ShouldThrowException(string name, string number)
        {
            //Assert
            Assert.Throws<Exception>(() => _target.PutNumber(name, number));
        }
    }
}