using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Handson.BookingEngine
{
    public abstract class SeatClass
    {
        public string Platinum { get; set; }

        public string Gold { get; set; }

        public string Silver { get; set; }

        public SeatRange Range { get; set; }

        public int SeatAvailability { get; set; }


        
    }
}
