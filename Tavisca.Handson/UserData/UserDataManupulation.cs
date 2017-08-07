using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tavisca.Handson.BookingEngine;

namespace UserData
{
    [TestClass]
    public class UserDataManupulation
    {
        [TestMethod]
        public void UserData()
        {
            UserManager userManager = new UserManager();

            User user1 = new User()
            {
                UserName = "amit",

                Password = "142536",

                ContactNumber = "7250788217",

                Location = new Address("pune", "Maharashtra", "India", "411033"),

                Name = new Name("Amit", "Prakash", "Sharma"),

                Gender= Gender.Male,

            };
            userManager.AddUser(user1);


            User user2 = new User()
            {
                UserName = "xylon",

                Password = "745896",

                ContactNumber = "9403117743",

                Location = new Address("Mumbai", "Maharashtra", "India", "411044"),

                Name = new Name("Subham", "Kumar", "Saraf"),

                Gender = Gender.Male,
            };
            userManager.AddUser(user2);

            User user3 = new User()
            {
                UserName = "neon",

                Password = "azsx1452",

                ContactNumber = "7250788215",

                Location = new Address("Ranchi", "Jharkhand", "India", "827012"),

                Name = new Name("Pratima", "Kumari", "Rai"),

                Gender = Gender.Female,
            };

            userManager.AddUser(user3);

            Assert.IsTrue(user1.UserName.Contains("amit"));
            Assert.IsTrue(user2.UserName.Contains("neon"));
            Assert.IsTrue(user3.UserName.Contains("xenon"));
        }
    }
}
