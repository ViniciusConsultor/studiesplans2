using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models.Interfaces;

namespace StudiesPlansModels.Models
{
    public class RolesRepository : IRolesRepository
    {
        public Role GetRole(string rolename)
        {
            return (from Role r in SPDatabase.DB.Roles
                    where string.Compare(r.Name, rolename, true) == 0
                    select r).FirstOrDefault();
        }

        public int GetRoleId(string rolename)
        {
            return (from Role r in SPDatabase.DB.Roles
                    where string.Compare(r.Name, rolename, true) == 0
                    select r.RoleID).FirstOrDefault();
        }

        public IEnumerable<Role> ListRoles()
        {
            return (from Role r in SPDatabase.DB.Roles
                    select r);
        }

        public void AddRole(NewRole role)
        {
            if (role != null)
            {
                Role r = new Role()
                {
                    Name = role.RoleName
                };
                SPDatabase.DB.Roles.AddObject(r);
                SPDatabase.DB.SaveChanges();
            }
        }

        public void DeleteRole(Role role)
        {
            if (role != null)
            {
                SPDatabase.DB.Roles.DeleteObject(role);
                SPDatabase.DB.SaveChanges();
            }
        }

        public void EditRole(RoleEdit role)
        {
            if (role != null)
            {
                Role r = this.GetRole(role.RoleID);
                if (r != null)
                {
                    r.Name = role.RoleName;
                    SPDatabase.DB.SaveChanges();
                }
            }
        }

        private Role GetRole(int roleId)
        {
            return (from Role r in SPDatabase.DB.Roles
                    where r.RoleID == roleId
                    select r).FirstOrDefault();
        }
    }
}
