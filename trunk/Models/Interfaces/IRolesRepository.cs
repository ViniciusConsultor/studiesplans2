using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlansModels.Models.Interfaces
{
    public interface IRolesRepository
    {
        Role GetRole(string rolename);
        int GetRoleId(string rolename);
        IEnumerable<Role> ListRoles();

        void AddRole(NewRole role);

        void DeleteRole(Role r);

        void EditRole(RoleEdit role);
    }
}
