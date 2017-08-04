using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Handson.BookingEngine
{
    public class Gold : ISeat
    {
        public string Range { get { return "B1-B2"; } }

        public void Book()
        {
            throw new NotImplementedException();
        }

        public int SeatAvailability { get; set; }
    }
}
