using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tavisca.Handson.BookingEngine;
using System.Collections.Generic;

namespace TheatreManager
{
    [TestClass]
    public class TheatreManager
    {

        [TestMethod]
        public void RegisterTheatre()
        {
            List<Theatre> registeredTheatre = new List<Theatre>();

            registeredTheatre.Add(new Theatre("PVR PHONEIX",5));

            registeredTheatre.Add(new Theatre("Cinepolis", 2));

            registeredTheatre.Add(new Theatre("Vishal E-square", 5));

            Assert.AreEqual(registeredTheatre.Count,3);


        }
    }
}
