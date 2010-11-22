using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;

namespace StudiesPlans.Controllers
{
    public class UserController
    {
        private static UserController instance;
        private IUsersRepository repository;

        public static UserController Instance
        {
            get
            {
                if (instance == null) 
                    instance = new UserController(new UsersRepository());

                return instance;
            }
        }

        public UserController(IUsersRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<User> ListUsers()
        {
            return this.repository.ListUsers();
        }

        public bool DeleteUser(string username)
        {
            User u = this.repository.GetUser(username);
            if (u != null)
            {
                this.repository.DeleteUser(u);
                return true;
            }
            return false;
        }

        public UserEdit GetUserEdit(string username)
        {
            User u = this.repository.GetUser(username);
            UserEdit ue = null;
            if (u != null)
            {
                ue = new UserEdit(u);
                ue.RoleID = u.RoleID;
            }
            return ue;
        }

        public bool UpdateUser(UserEdit user)
        {
            if (!user.Password.Equals(user.RepeatPassword))
                user.AddError("Oba hasła muszą być identyczne");

            User u = this.repository.GetUser(user.UserName);
            if (u != null && ((u.UserID != user.UserID) && u.Name.ToLower().Equals(user.UserName.ToLower())))
                user.AddError("Użytkownik o takiej nazwie już istnieje");

            if (user.IsValid)
            {
                if (!this.repository.EditUser(user))
                {
                    user.AddError("Użytkownik nie istnieje");
                    return false;
                }
                else
                    return true;
            }
            return false;
        }

        public bool AddUser(NewUser user)
        {
            if (!user.Password.Equals(user.RepeatPassword))
                user.AddError("Oba hasła muszą być identyczne");
            if (this.repository.UserExists(user.UserName))
                user.AddError("Użytkownik o takiej nazwie już istnieje");

            if (user.IsValid)
            {
                this.repository.AddUser(user);
                return true;
            }
            return false;
        }
    }
}
