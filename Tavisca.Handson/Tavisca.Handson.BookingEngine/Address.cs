using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Handson.BookingEngine
{
    public class Address
    {
        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PinCode { get; set; }

        public Address(string city, string state, string country, string pinCode)
        {
            City = city;

            State = state;

            Country = country;

            PinCode = pinCode;
        }
    }
}
