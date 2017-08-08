using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikersClubEnrollment
{
    public class Name
    {
        public Title Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public Name(Title title, string firstName, string middleName, string lastName)
        {
            Title = title;

            FirstName = firstName;

            MiddleName = middleName;

            LastName = lastName;
        }
        public override string ToString()
        {
            return Title+" " + FirstName+" " + MiddleName +" "+LastName;
        }
    }
}
