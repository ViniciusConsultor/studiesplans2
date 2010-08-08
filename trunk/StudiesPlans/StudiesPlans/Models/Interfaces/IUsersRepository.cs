using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlans.Models
{
    interface IUsersRepository
    {
        void AddUser(NewUser user);
        void DeleteUser(int userId);
        void EditUser(UserEdit user);
        User GetUser(int userId);
        User GetUser(string name, string password);
        IEnumerable<User> ListUsers();
    }
}
