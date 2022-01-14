using System;
using NUnit.Framework;

namespace Exercise_8.Tests
{
    public class Tests
    {
        [Test]
        public void CalculatePay_PayRateTooSmall_ExpectedSmthIsNotRightHereString()
        {
            //Arrange
            double payRate = 7.50;
            int hours = 40;
            
            //Assert
            Assert.AreEqual(Methods.CalculatePay(payRate, hours), "Something is not right here...");
        }

        [Test]
        public void CalculatePay_HoursTooBig_ExpectedSmthIsNotRightHereString()
        {
            //Arrange
            double payRate = 10.00;
            int hours = 99;
            
            //Assert
            Assert.AreEqual(Methods.CalculatePay(payRate, hours), "Something is not right here...");
        }

        [Test]
        public void CalculatePay_PayRate10Hours40_ExpectedEmployeeEarnedThisWeekString()
        {
            //Arrange
            double payRate = 10.00;
            int hours = 40;
            
            //Assert
            Assert.AreEqual(Methods.CalculatePay(payRate, hours), $"Employee earned {Math.Round(payRate * hours, 2)}$ this week.");
        }

        [Test]
        public void CalculatePay_PayRate10Hours50_ExpectedEmployeeEarnedThisWeekWithOvertimeString()
        {
            //Arrange
            double payRate = 10.00;
            int hours = 50;
            int overtime = hours - 40;
            double overtimePayRate = payRate * 1.5;
            
            //Assert
            Assert.AreEqual(Methods.CalculatePay(payRate, hours), $"Employee earned {Math.Round(payRate * 40 + overtime * overtimePayRate, 2)}$ this week.");
        }
    }
}