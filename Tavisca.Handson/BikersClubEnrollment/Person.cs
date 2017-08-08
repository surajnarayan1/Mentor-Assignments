using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikersClubEnrollment
{
    public class Person
    {
        public Name Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public String Age { get; set; }

        public Gender Gender { get; set; }

        public Person()
        {
            Name = new Name(Title.Mr, "Amit", "Prakash", "Kashyap");

            DateOfBirth = new DateTime(2008, 5, 1, 8, 30, 52);

            Age = "Age=25";

            Gender=Gender.Male;

        }
        public override string ToString()
        {
            return "Person: "+Name+ " " + " " +DateOfBirth+ " " + Age+ " " + Gender;
        }
        
    }
}
