using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Security.Cryptography;
using StudiesPlansModels.Models.Interfaces;

namespace StudiesPlansModels.Models
{
    public class UsersRepository : IUsersRepository
    {
        private static string postfix = "Addherepostfix";

        public void AddUser(NewUser user)
        {
            if (user != null)
            {
                User toAdd = new User()
                {
                    Email = user.Email == null ? string.Empty : user.Email,
                    Name = user.UserName,
                    Password = HashPassword(user.Password),
                    RoleID = user.RoleID,
                };

                SPDatabase.DB.Users.AddObject(toAdd);
                SPDatabase.DB.SaveChanges();
            }
        }

        public void DeleteUser(User user)
        {
            SPDatabase.DB.Users.DeleteObject(user);
            SPDatabase.DB.SaveChanges();
        }

        public bool EditUser(UserEdit user)
        {
            User u = this.GetUser(user.UserID);
            if (u != null)
            {
                u.Name = user.UserName;
                u.Password = HashPassword(user.Password);
                u.Email = user.Email;
                u.RoleID = user.RoleID;
                SPDatabase.DB.SaveChanges();
                return true;
            }
            return false;
        }

        public void EditUser(UserLastActive user)
        { 
            if (user == null)
                return;

            User toEdit = this.GetUser(user.UserID);
            if (toEdit != null)
            {
                toEdit.LastActiveDate = user.LastActiveDate;
                SPDatabase.DB.SaveChanges();
            }
        }

        public User GetUser(string username, string password)
        {
            string hashedPassword = HashPassword(password);

            return (from User u in SPDatabase.DB.Users
                    where string.Compare(u.Name, username, false) == 0
                    && string.Compare(u.Password, hashedPassword, true) == 0
                    select u).FirstOrDefault();
        }

        public User GetUser(string username)
        {
            return (from User u in SPDatabase.DB.Users
                    where string.Compare(u.Name, username, false) == 0
                    select u).FirstOrDefault();
        }

        public User GetUser(int userId)
        {
            return (from User u in SPDatabase.DB.Users
                    where u.UserID == userId select u).FirstOrDefault();
        }

        public IEnumerable<User> ListUsers()
        {
            return (from User u in SPDatabase.DB.Users select u);
        }

        public string HashPassword(string password)
        {
            password += postfix;

            Encoder enc = System.Text.Encoding.Unicode.GetEncoder();
            byte[] unicodeText = new byte[password.Length * 2];
            enc.GetBytes(password.ToCharArray(), 0, password.Length, unicodeText, 0, true);

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(unicodeText);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
                sb.Append(result[i].ToString("X2"));

            return sb.ToString();
        }

        public bool UserExists(string username)
        {
            if (this.GetUser(username) != null)
                return true;
            else
                return false;
        }
    }
}
