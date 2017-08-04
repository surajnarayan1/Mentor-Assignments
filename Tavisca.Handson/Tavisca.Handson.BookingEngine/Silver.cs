using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Handson.BookingEngine
{
    public class Silver : ISeat
    {

        public int SeatAvailability { get; set; }

        public string Range { get { return "C1-C2"; } }

        public void Book()
        {
            throw new NotImplementedException();
        }
    }
}
