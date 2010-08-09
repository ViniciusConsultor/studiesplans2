using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlans.Models;

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
    }
}
