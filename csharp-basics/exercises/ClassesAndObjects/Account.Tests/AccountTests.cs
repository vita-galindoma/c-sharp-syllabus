using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Account.Tests
{
    [TestClass]
    public class AccountTests
    {
        private Account _target;

        [TestMethod]
        public void Withdrawal_Input100_9900Expected()
        {
            //Arrange
            _target = new Account("account", 10000);

            //Act
            var result = _target.Withdrawal(100);
            var expectedBalance = 9900;

            //Assert
            Assert.AreEqual(expectedBalance, result);
        }

        [TestMethod]
        public void Deposit_Input100_10100Expected()
        {
            //Arrange
            _target = new Account("account", 10000);

            //Act
            var result = _target.Deposit(100);
            var expectedBalance = 10100;

            //Assert
            Assert.AreEqual(expectedBalance, result);
        }

        [TestMethod]
        public void Balance_InputBalance100_Depo100_Withdraw50_150Expected()
        {
            //Arrange
            _target = new Account("account", 100);
            _target.Deposit(100);
            _target.Withdrawal(50);

            //Act
            var result = _target.Balance();
            var expectedBalance = 150;

            //Assert
            Assert.AreEqual(expectedBalance, result);
        }

        [TestMethod]
        public void Transfer_2acc100balanceTransfer25_75Expected()
        {
            //Arrange
            _target = new Account("account1", 100);
            var account2 = new Account("account2", 100);

            //Act
            var expectedBalance = 75;
            Account.Transfer(_target, account2, 25);
            var result = _target.Balance();

            //Assert
            Assert.AreEqual(expectedBalance, result);
        }

        [TestMethod]
        public void ToString_InputAcc100Balance_StringExpected()
        {
            //Arrange
            _target = new Account("account", 100);
            var expectedResult = "account: 100.0";

            //Act
            var result = _target.ToString();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
