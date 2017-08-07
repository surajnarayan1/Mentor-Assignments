using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Handson.BookingEngine
{
    public class UserManager
    {
        List<User> user = new List<User>();


        public void AddUser(User users)
        {
            user.Add(users);
        }

        //public List<User> GetUser()
        //{
        //    return List<UserManager.>
        //}
    }
}
