using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Security.Cryptography;

namespace StudiesPlans.Models
{
    public class UsersRepository : IUsersRepository
    {
        private static string postfix = "Addherepostfix";

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

        public User GetUser(string username, string password)
        {
            string hashedPassword = HashPassword(password);

            return (from User u in SPDatabase.DB.Users
                    where string.Compare(u.Name, username, false) == 0
                    && string.Compare(u.Password, hashedPassword, true) == 0
                    select u).FirstOrDefault();
        }

        public User GetUser(int userId)
        {
            return null;
        }

        public IEnumerable<User> ListUsers()
        {
            return null;
        }

        private string HashPassword(string password)
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
    }
}
