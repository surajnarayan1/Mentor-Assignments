using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Handson.BookingEngine
{
    public class Screen
    {
        public List<SeatCategory> Seat { get; set; }

        public int ScreenNumber { get; set; }

        public List<Movie> PlayingMovies { get; set; }

        public List<TimeSlot> ShowSlots { get; set; }

        public Screen(int screenNumber, List<Movie> Movies, List<TimeSlot> Timeslot)
        {
            ScreenNumber = screenNumber;

            PlayingMovies = Movies;

           // Seat = SeatList;

            ShowSlots = Timeslot;

        }

    }
}
