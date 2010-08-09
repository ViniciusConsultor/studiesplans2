using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlans.Models;
using System.Security.Cryptography;

namespace StudiesPlans.Controllers
{
    public class AccountController
    {

        private IUsersRepository repository;
        private static AccountController instance;

        public static AccountController Instance
        {
            get
            {
                if (instance == null) 
                    instance = new AccountController(new UsersRepository());

                return instance;
            }
        }

        public AccountController(IUsersRepository repository)
        {
            this.repository = repository;
        }

        public User LoginUser(ref UserLogin user)
        {
            if (user.IsValid())
            {
                User logged = this.repository.GetUser(user.UserName, user.Password);
                if (logged == null)
                    user.AddError("Błędne dane logowania");
                return logged;
            }
            return null;
        }

        public void UpdateLastActiveUser(UserLastActive user)
        {
            if (user == null)
                return;

            User toEdit = this.repository.GetUser(user.UserID);
            if (toEdit != null)
            {
                toEdit.LastActiveDate = user.LastActiveDate;
                SPDatabase.DB.SaveChanges();
            }
        }
    }
}
