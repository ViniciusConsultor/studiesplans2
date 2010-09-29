using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;
using StudiesPlans.Controllers;

namespace StudiesPlans.Views
{
    public partial class Roles : Form
    {
        private RoleEdit roleToEdit = null;
        private bool changes = false;

        public Roles()
        {
            InitializeComponent();
            FillWithRoles();
            Clear();
        }

        private void FillWithRoles()
        {
            listRoles.Items.Clear();
            IEnumerable<Role> roles = RoleController.Instance.ListRoles();
            if (roles != null)
            {
                foreach (Role r in roles)
                    listRoles.Items.Add(r.Name);
            }
        }

        private void Clear()
        {
            lblValidation.Text = string.Empty;
            tbNewRoleName.Text = string.Empty;
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            NewRole role = new NewRole()
            {
                RoleName = tbNewRoleName.Text
            };
            if (!RoleController.Instance.AddRole(role))
            {
                string errors = string.Empty;
                foreach (string error in role.Errors)
                {
                    errors = errors + error + "\n";
                }
                lblValidation.Text = errors;
            }
            else
            {
                changes = true;
                FillWithRoles();
                Clear();
            }
        }

        private void listRoles_DoubleClick(object sender, EventArgs e)
        {
            RoleEdit role = RoleController.Instance.GetRoleEdit(listRoles.SelectedItem.ToString());
            if (role != null)
            {
                roleToEdit = role;
                btnAddRole.Enabled = false;
                btnCancel.Enabled = true;
                btnDeleteRole.Enabled = true;
                btnUpdate.Enabled = true;
                tbNewRoleName.Text = role.RoleName;
            }
            else
            {
                lblValidation.Text = "Rola nie istnieje";
                roleToEdit = null;
            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            if (roleToEdit != null)
            {
                try
                {
                    RoleController.Instance.DeleteRole(roleToEdit);
                    FillWithRoles();
                    changes = true;
                    roleToEdit = null;
                }
                catch (UpdateException ex)
                {
                    lblValidation.Text = ex.Message;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Disable();
            Clear();
        }

        private void Disable()
        {
            btnAddRole.Enabled = true;
            btnCancel.Enabled = false;
            btnDeleteRole.Enabled = false;
            btnUpdate.Enabled = false;
            roleToEdit = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (roleToEdit != null)
            {
                roleToEdit.RoleName = tbNewRoleName.Text;
                if (!RoleController.Instance.EditRole(roleToEdit))
                {
                    string errors = string.Empty;
                    foreach (string error in roleToEdit.Errors)
                    {
                        errors = errors + error + "\n";
                    }
                    lblValidation.Text = errors;
                }
                else
                {
                    FillWithRoles();
                    Clear();
                    roleToEdit = null;
                    Disable();
                    changes = true;
                }
            }
        }

        private void Roles_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
                this.DialogResult = DialogResult.Yes;
        }
    }
}
