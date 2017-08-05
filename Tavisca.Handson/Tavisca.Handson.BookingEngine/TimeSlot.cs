using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Handson.BookingEngine
{
    public class TimeSlot
    {
        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public Movie Movie { get; set; }
    }
}
