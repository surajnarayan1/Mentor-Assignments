using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tavisca.Handson.BookingEngine;
using System.Collections.Generic;

namespace TheatreData
{
    [TestClass]
    public class TheatreDataManupulation
    {
        [TestMethod]
        public void TheatreData()
        {
            List<Movie> movies = new List<Movie>();
            Movie movie = new Movie();

            movie.Name = "DDLG";

            movie.Rating = 5;

            movie.ReleaseDate = "10/01/2016";

            movies.Add(movie);

            List<Seat> seats = new List<Seat>();

            Seat seat = new Seat();

            seat.SeatAvailable = 10;

            seats.Add(seat);

            List<TimeSlot> timeSlots = new List<TimeSlot>();

            TimeSlot movieSlot = new TimeSlot();

            movieSlot.StartTime = 10;

            movieSlot.EndTime = 12;

            movieSlot.Movie = movie;

            timeSlots.Add(movieSlot);


            Theatre theatre = new Theatre()
            {
                Name = "PVR",
                Location = new Address("Pune", "Maharashtra", "Indian","411044"),
                Rating = 5,
                    Screens = new List<Screen>()
                     {
                           new Screen(5,movies,timeSlots)
                     }
                
                };
               TheatreManager theatreManager = new TheatreManager();
               theatreManager.AddTheatre(theatre);
               
                Assert.IsTrue(theatre.Name.Contains("PVR"));
            
        }
    }
}
