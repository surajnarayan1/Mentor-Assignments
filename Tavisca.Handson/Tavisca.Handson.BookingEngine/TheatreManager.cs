using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Handson.BookingEngine
{
    public class TheatreManager
    {
         List<Theatre> theatres = new List<Theatre>();

        public void AddTheatre(Theatre theatre)
        {
            theatres.Add(theatre);
        }
            

    }
}
