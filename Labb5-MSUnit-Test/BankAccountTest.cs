using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamGrapeBankApp;

namespace Labb5_MSUnit_Test
{
    [TestClass]
    public class BankAccountTest
    {

        [TestMethod]
        public void InternalTransaction_ShouldTransferMoneyFromOneAccountToTheOther()
        {
            //Arrange
            List<BankAccount> bankAccounts = new List<BankAccount>();
            List<User> cus = new List<User>();
            User testUser = new Customer(5, "ken", "pass1", "Bill", "Gates", "Nygatan 26 31176 Varberg", "bill@microsoft.se", "+46702222222", false);
            BankAccount testAccount = new BankAccount("Bills", "3005-3135", "ken", "SEK", 1000000m);
            BankAccount testAccount2 = new BankAccount("Salary Account", "1337-3341", "ken", "SEK", 50000m);

            cus.Add(testUser);
            bankAccounts.Add(testAccount);
            bankAccounts.Add(testAccount2);


            var FromAccountBeforeTransfer = testAccount.Balance;
            var ToAccountBeforeTransfer = testAccount2.Balance;
            //Act
            BankAccount.InternalTransaction("ken", testAccount, testAccount2, 50000m);


            //Assert
            Assert.AreNotEqual(FromAccountBeforeTransfer, testAccount.Balance);
            Assert.AreNotEqual(ToAccountBeforeTransfer, testAccount2.Balance);

        }
    }
}
