using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Handson.BookingEngine
{
    public abstract class Seat
    {
        // void Book();

        string Range { get; }

        public int SeatAvailability { get; set; }
    }
}
