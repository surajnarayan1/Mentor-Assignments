using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Handson.BookingEngine
{
    public class Theatre
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public double Rating { get; set; }

        List<Screen> Screens { get; set; }
        


        //public Theatre(string theatreName, string theatreLocation, double movieRating)
        //{
        //    name = theatreName;

        //    location = theatreLocation;

        //    rating = movieRating;

        //}
    }
}
