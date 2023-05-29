using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection.Metadata;
using TeamGrapeBankApp;







namespace Labb5_MSUnit_Test
{
    [TestClass]
    public class LoginTest
    {

        [TestMethod]
        public void GenerateUsers_AddUsersToList_ShouldReturnFourUsers()
        {
            //Arrange
            var exspectedCount = 4;

            //Act
            User.GenerateUsers();

            //Assert
            Assert.AreEqual(exspectedCount, User.userList.Count);
        }




        [TestMethod]
        public void Login_SuccessfulLogin_CorrectUserName()
        {
            string exspectedUserName = "johan";
            User johan = new Customer(6, "johan", "hej", "Johan", "Svensson", "Nygatan 26 31176 Falkenberg", "bill@microsoft.se", "+46702222222", false);

            string actualUserName = johan.Username;

            Assert.AreEqual(exspectedUserName, actualUserName);



        }

        [TestMethod]
        public void Login_SuccessfullLogin_CorrectPassword()
        {
            string exspectedPassword = "hej";
            User johan = new Customer(6, "johan", "hej", "Johan", "Svensson", "Nygatan 26 31176 Falkenberg", "bill@microsoft.se", "+46702222222", false);

            string actualPassWord = johan.Password;

            Assert.AreEqual(exspectedPassword, actualPassWord);
        }


        [TestMethod]
        public void Login_SuccessfulLogin_CorrectUserNamne_CorrectPassword()
        {
            // Arrange


            User sven = new Customer(1, "billgates", "pass1", "Bill", "Gates", "Nygatan 26 31176 Falkenberg", "bill@microsoft.se", "+46702222222", false);

            string enteredUsername = "billgates";
            string enteredPassword = "pass1";

            // Act
            User.Login(enteredUsername, enteredPassword);

            // Assert
           Assert.AreEqual(enteredUsername, sven.Username);
           Assert.AreEqual(enteredPassword, sven.Password);

        }



    }

}
 