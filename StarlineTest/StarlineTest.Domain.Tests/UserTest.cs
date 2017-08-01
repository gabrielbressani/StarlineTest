using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarlineTest.Domain.Entities;

namespace StarlineTest.Domain.Tests
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void If_User_Is_Active_And_Registration_Year_Date_Is_Actual_Year_Then_UserActiveOfThisYear_Is_True()
        {
            var user = new User()
            {
                Active = true,
                RegistrationDate = DateTime.Now
            };

            var actual = user.UserActiveOfThisYear(user);

            Assert.IsTrue(actual);
        }
    }
}
