using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace StudiesPlans.Models
{
    public class UsersRepository : IUsersRepository
    {
        public void AddUser(NewUser user)
        {
            if (user == null)
                return;

            User toAdd = new User()
            {
                Email = user.Email == null ? string.Empty : user.Email,
                Name = user.UserName,
                Password = user.Password,
                RoleID = user.RoleID,
            };

            SPDatabase.DB.Users.AddObject(toAdd);
            SPDatabase.DB.SaveChanges();
        }

        public void DeleteUser(int userId)
        { }

        public void EditUser(UserEdit user)
        { }

        public User GetUser(int userId)
        { 
            return null; 
        }

        public User GetUser(string name, string password)
        {
            return null;
        }

        public IEnumerable<User> ListUsers()
        {
            return null;
        }
    }
}
