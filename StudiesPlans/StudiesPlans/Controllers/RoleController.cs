using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlans.Models.Interfaces;
using StudiesPlans.Models;
using StudiesPlans.Helpers;
using System.Data;

namespace StudiesPlans.Controllers
{
    public class RoleController
    {
        private static RoleController instance;
        private IRolesRepository repository;

        public static RoleController Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoleController(new RolesRepository());

                return instance;
            }
        }

        public RoleController(IRolesRepository repository)
        {
            this.repository = repository;
        }

        public int GetRoleId(string rolename)
        {
            return this.repository.GetRoleId(rolename);
        }

        public IEnumerable<Role> ListRoles()
        {
            return this.repository.ListRoles();
        }

        public bool AddRole(NewRole role)
        {
            if (role != null)
            { 
                Role r = this.repository.GetRole(role.RoleName);
                if (r != null)
                    role.AddError("Rola o podanej\nnazwie już istnieje");
                if (role.IsValid)
                {
                    this.repository.AddRole(role);
                    return true;
                }
                return false;
            }
            return false;
        }

        public RoleEdit GetRoleEdit(string rolename)
        {
            Role r = this.repository.GetRole(rolename);
            if (r != null)
            {
                RoleEdit role = new RoleEdit()
                {
                    RoleID = r.RoleID,
                    RoleName = r.Name
                };
                return role;
            }
            return null;
        }

        public void DeleteRole(RoleEdit roleToEdit)
        {
            Role r = this.repository.GetRole(roleToEdit.RoleName);
            if (r != null && r.Users.Count > 0)
                throw new UpdateException("Nie można usunąć roli, ponieważ\nposiada powiązania");
            else
            {
                this.repository.DeleteRole(r);
            }
        }

        public bool EditRole(RoleEdit role)
        {
            if (role != null)
            {
                Role r = this.repository.GetRole(role.RoleName);
                if (r != null)
                    role.AddError("Rola o podanej\nnazwie już istnieje");
                if (role.IsValid)
                {
                    this.repository.EditRole(role);
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
