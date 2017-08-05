using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tavisca.Handson.BookingEngine;
using System.Collections.Generic;

namespace UserData
{
    [TestClass]
    public class UserManager
    {
       
        [TestMethod]
        public void CreateUser()
        {
            List<User> users = new List<User>();

            users.Add(new User("Amit","12345","9403117743"));

            users.Add(new User("Prakash", "147852", "7250788217"));

            users.Add(new User("Subham", "1236547", "7843028464"));

            Assert.AreEqual(users.Count, 3);
        }
    }
}
