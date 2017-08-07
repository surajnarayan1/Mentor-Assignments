using System.Collections.Generic;

namespace Tavisca.Handson.BookingEngine

{
    public class SeatCategory
    {
        public List<Seat> Seats;

        public string Name;

        public char StartingRow;

        public char EndingRow;

        public int NumberOfSeatsInARow;
    }
}
