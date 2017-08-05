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

        public Address Location { get; set; }

        public double Rating { get; set; }

        List<Screen> Screens { get; set; }



        public Theatre(string theatreName, double movieRating)
            
        {
            Name = theatreName;

           // Location = theatreLocation;

            Rating = movieRating;

         //   Screens = noOfScreens;

        }
    }
}
