using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlansModels.Models.Interfaces
{
    public interface IUsersRepository
    {
        void AddUser(NewUser user);
        void DeleteUser(User user);
        bool EditUser(UserEdit user);
        void EditUser(UserLastActive user);
        User GetUser(int userId);
        User GetUser(string name, string password);
        User GetUser(string name);
        IEnumerable<User> ListUsers();
        bool UserExists(string username);
        string HashPassword(string passwod);
    }
}
