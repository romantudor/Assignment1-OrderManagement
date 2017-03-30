using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Operations;
namespace OperationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Login()
        {
            string userName = "admin";
            string password = "admin";
            UserOperations bl = new UserOperations();

            User user = bl.Login(userName, password);

            Assert.AreEqual(user.IsAdmin, true);
        }
    }
}
