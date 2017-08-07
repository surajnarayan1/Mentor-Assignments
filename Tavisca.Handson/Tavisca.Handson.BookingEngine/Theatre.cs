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

        public List<Screen> Screens { get; set; }



        //public Theatre(string theatreName,Address theatreLoaction, double movieRating)

        //{
        //    Name = theatreName;

        //    Location = theatreLoaction;

        //    Rating = movieRating;

        //    Screens = new List<Screen>();

        //}
    }
}
