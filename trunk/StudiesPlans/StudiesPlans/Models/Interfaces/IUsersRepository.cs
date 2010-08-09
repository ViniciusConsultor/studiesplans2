using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlans.Models
{
    public interface IUsersRepository
    {
        void AddUser(ref NewUser user);
        void DeleteUser(int userId);
        void EditUser(UserEdit user);
        void EditUser(UserLastActive user);
        User GetUser(int userId);
        User GetUser(string name, string password);
        IEnumerable<User> ListUsers();
    }
}
