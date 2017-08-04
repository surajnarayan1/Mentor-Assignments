using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Handson.BookingEngine
{
    public class Platinum : ISeat
    {

        public string Range { get { return "A1-A2"; } }

        public void Book()
        {
            throw new NotImplementedException();
        }

        public int SeatAvailability { get; set; }
    }
}
