using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TeamGrapeBankApp;

namespace Labb5_MSUnit_Test
{
    [TestClass]
    public class LoanAccountTest
    {

        [TestMethod]
        public void LoanLimit_AmmountShouldNotGoOverLimit()
        {

            // Arrange
            List<BankAccount> bankAccounts = new List<BankAccount>();
            User jon = new Customer(5, "Jon", "hej123", "Jon", "Henning", "Södravägen 41C", "jon@hotmail.com", "0702556677", false);
            BankAccount trvl = new BankAccount("Travel", "11112222", "Jon", "SEK", 10000m);
            bankAccounts.Add(trvl);

            // Act
            decimal actual = LoanAccount.LoanLimit(jon, bankAccounts);
            decimal expected = 50000m;

            // Assert
            Assert.AreEqual(expected, actual);





        }
    }
}
