using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Handson.BookingEngine
{
    public class User
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string ContactNumber { get; set; }

        public Gender Gender { get; set; }

        public Address Location { get; set; }

        public Name Name { get; set; }

        public User(string userName, string password, string contactNumber)
        {
            this.UserName = userName;

            this.Password = password;

            this.ContactNumber = contactNumber;

            //  this.Gender = gender;

        }
    }

}
