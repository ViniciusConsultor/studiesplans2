using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;
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
                    role.AddError("Rola o podanej nazwie już istnieje");
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
                    RoleName = r.Name,
                    Privilages = r.Privilages
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
                if (r != null && r.RoleID != role.RoleID && r.Name.ToLower().Equals(role.RoleName.ToLower()))
                    role.AddError("Rola o podanej\nnazwie już istnieje");
                if (role.IsValid)
                {
                    r = this.repository.GetRole(role.RoleID);
                    r.Name = role.RoleName;
                    r.Privilages.Clear();
                    foreach (Privilage p in role.Privilages)
                        r.Privilages.Add(p);

                    this.repository.EditRole(role);
                    return true;
                }
                return false;
            }
            return false;
        }

        public IEnumerable<Privilage> ListPrivilages()
        {
            return this.repository.ListPrivilages();
        }

        public Privilage GetPrivilage(string name)
        {
            return this.repository.GetPrivilage(name);
        }

        public Role GetRole(int roleId)
        {
            return this.repository.GetRole(roleId);
        }
    }
}
