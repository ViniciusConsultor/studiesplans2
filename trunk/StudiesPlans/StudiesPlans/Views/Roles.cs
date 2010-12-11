using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;
using StudiesPlans.Controllers;

namespace StudiesPlans.Views
{
    public partial class Roles : Telerik.WinControls.UI.RadForm
    {

        private RoleEdit roleToEdit = null;
        private bool changes = false;

        public Roles()
        {
            InitializeComponent();
            FillWithRoles();
            FillWithPrivilages();
            Clear();
            ShowButtonsToolTips();
        }

        private void ShowButtonsToolTips()
        {
            btnAdd.ButtonElement.ToolTipText = "Dodaj rolê";
            btnCancel.ButtonElement.ToolTipText = "Anuluj edycjê";
            btnDelete.ButtonElement.ToolTipText = "Usuñ rolê";
            btnSave.ButtonElement.ToolTipText = "Zapisz zmiany";
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

        private void FillWithPrivilages()
        {
            clbPrivilages.Items.Clear();
            IEnumerable<Privilage> privilages = RoleController.Instance.ListPrivilages();
            if (privilages != null)
                foreach (Privilage p in privilages)
                    clbPrivilages.Items.Add(p.Name);
        }

        private void Clear()
        {
            lblValidation.Text = string.Empty;
            tbNewRoleName.Text = string.Empty;
            clbPrivilages.ClearSelected();
            for (int i = 0; i < clbPrivilages.Items.Count; i++)
                clbPrivilages.SetItemChecked(i, false);
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            NewRole role = new NewRole()
            {
                RoleName = tbNewRoleName.Text
            };

            List<string> list = clbPrivilages.CheckedItems.Cast<string>().ToList<string>();
            if (list != null && list.Count > 0)
            {
                List<Privilage> privilages = new List<Privilage>();
                foreach (string name in list)
                {
                    Privilage p = RoleController.Instance.GetPrivilage(name);
                    if (p != null)
                        privilages.Add(p);
                }
                role.Privilages = privilages.AsEnumerable();
            }
            else
                role.Privilages = null;

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
            if (listRoles.SelectedIndex >= 0)
            {
                RoleEdit role = RoleController.Instance.GetRoleEdit(listRoles.SelectedItem.ToString());
                if (role != null)
                {
                    roleToEdit = role;
                    btnAdd.Enabled = false;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = true;
                    tbNewRoleName.Text = role.RoleName;

                    for (int i = 0; i < clbPrivilages.Items.Count; i++)
                        clbPrivilages.SetItemChecked(i, false);

                    if (role.Privilages != null)
                    {
                        foreach (Privilage p in role.Privilages)
                        {
                            for (int i = 0; i < clbPrivilages.Items.Count; i++)
                                if (p.Name.Equals(clbPrivilages.Items[i].ToString()))
                                {
                                    clbPrivilages.SetItemChecked(i, true);
                                    break;
                                }
                        }
                    }
                }
                else
                {
                    lblValidation.Text = "Rola nie istnieje";
                    roleToEdit = null;
                }
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
                    Clear();
                    changes = true;
                    roleToEdit = null;
                    Disable();
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
            btnAdd.Enabled = true;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            roleToEdit = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (roleToEdit != null)
            {
                roleToEdit.ClearErrors();
                roleToEdit.RoleName = tbNewRoleName.Text;

                List<string> list = clbPrivilages.CheckedItems.Cast<string>().ToList<string>();
                if (list != null && list.Count > 0)
                {
                    List<Privilage> privilages = new List<Privilage>();
                    foreach (string name in list)
                    {
                        Privilage p = RoleController.Instance.GetPrivilage(name);
                        if (p != null)
                            privilages.Add(p);
                    }
                    roleToEdit.Privilages = privilages.AsEnumerable();
                }
                else
                    roleToEdit.Privilages = null;

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
