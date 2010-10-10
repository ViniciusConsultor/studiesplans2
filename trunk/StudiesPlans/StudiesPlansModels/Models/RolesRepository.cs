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

        public IEnumerable<Privilage> ListPrivilages()
        {
            return (from Privilage p in SPDatabase.DB.Privilages
                    select p);
        }

        public void AddRole(NewRole role)
        {
            if (role != null)
            {
                Role r = new Role()
                {
                    Name = role.RoleName
                };

                foreach (Privilage p in role.Privilages)
                {
                    r.Privilages.Add(p);
                }

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

        public Role GetRole(int roleId)
        {
            return (from Role r in SPDatabase.DB.Roles
                    where r.RoleID == roleId
                    select r).FirstOrDefault();
        }

        public Privilage GetPrivilage(string name)
        {
            return (from Privilage p in SPDatabase.DB.Privilages
                    where string.Compare(p.Name, name, true) == 0
                    select p).FirstOrDefault();
        }
    }
}
