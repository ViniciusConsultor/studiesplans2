using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using System.Resources;
using StudiesPlans.Views;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;
using StudiesPlans.Controllers;
namespace StudiesPlans.Views
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        UserEdit userToEdit = null;

        public MainForm(User user)
        {
            InitializeComponent();
            pages.Pages.Remove(plancreate);
            pages.Pages.Remove(review);
            pages.Pages.Remove(archive);
            pages.Pages.Remove(users);
            ManageUsers(user);
            lRole.Text += user.Role.Name;
            lUserName.Text += user.Name;

        }

        private void ManageUsers(User user)
        {
            bool wasPlan = false;
            for (int i = 0; i < user.Role.Privilages.Count(); i++)
            {
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Edycja"))
                {
                    if (wasPlan == false)
                    {
                        pages.Pages.Add(plancreate);
                        wasPlan = true;
                    }
                }
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Recenzowanie") && wasPlan == false)
                    pages.Pages.Add(plancreate);
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Przegl퉐anie"))
                    pages.Pages.Add(review);
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Archiwizacja"))
                    pages.Pages.Add(archive);
                if (user.Role.Privilages.ElementAt(i).Name.Equals("U퓓tkownicy"))
                    pages.Pages.Add(users);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void updateGUI()
        {
            Application.DoEvents();
            this.Invalidate();
            this.Update();
            System.Threading.Thread.Sleep(1);
        }

        public void FillWithUsers()
        {
            gridUsers.Rows.Clear();
            IEnumerable<User> users = UserController.Instance.ListUsers();
            if (users != null)
            {
                foreach (User u in users)
                {
                    string email = u.Email == null ? string.Empty : u.Email;
                    string lastActiveDate = string.Empty;
                    if (u.LastActiveDate.HasValue)
                        lastActiveDate = u.LastActiveDate.Value.ToString();

                    gridUsers.Rows.Add(u.Name, email, lastActiveDate, u.Role.Name, 
                        Properties.Resources.edit, Properties.Resources.delete);
                }
            }

            cbRoles.Items.Clear();
            IEnumerable<Role> roles = RoleController.Instance.ListRoles();
            if (roles != null)
            {
                foreach (Role r in roles)
                    cbRoles.Items.Add(r.Name);
                cbRoles.SelectedIndex = 0;
            }
        }

        private bool EditUser(UserEdit u)
        {
            if (u != null)
            {
                u.UserName = tbNewUsername.Text;
                u.Password = tbNewPassword.Text;
                u.RepeatPassword = tbNewRepeatPassword.Text;
                u.Email = tbNewEmail.Text;
                int roleId = RoleController.Instance.GetRoleId(cbRoles.SelectedItem.ToString());
                if (roleId > 0)
                    u.RoleID = roleId;

                //todo role doesn't exist

                if (!UserController.Instance.UpdateUser(u))
                {
                    string errors = string.Empty;
                    foreach (string error in u.Errors)
                        errors = errors + error + "\n";
                    lblValidation.Text = errors;
                    return false;
                }
            }
            FillWithUsers();
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (EditUser(userToEdit))
            {
                btnUpdate.Enabled = false;
                btnCancelEdit.Enabled = false;
                btnAddUser.Enabled = true;
                Clear();
                userToEdit = null;
            }
        }

        private void Clear()
        {
            tbNewEmail.Text = string.Empty;
            tbNewPassword.Text = string.Empty;
            tbNewRepeatPassword.Text = string.Empty;
            tbNewUsername.Text = string.Empty;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            NewUser user = new NewUser()
            {
                Email = tbNewEmail.Text,
                Password = tbNewPassword.Text,
                RepeatPassword = tbNewRepeatPassword.Text,
                UserName = tbNewUsername.Text,
                RoleID = RoleController.Instance.GetRoleId(cbRoles.SelectedItem.ToString())
            };
            if (!UserController.Instance.AddUser(user))
            {
                string errors = string.Empty;
                foreach (string error in user.Errors)
                    errors = errors + error + "\n";
                lblValidation.Text = errors;
            }
            else
            {
                Clear();
                FillWithUsers();
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            userToEdit = null;
            btnAddUser.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancelEdit.Enabled = false;
            Clear();
            lblValidation.Text = string.Empty;
        }

        private void btnRolesMngmt_Click(object sender, EventArgs e)
        {
            if (new Roles().ShowDialog() == DialogResult.Yes)
                FillWithUsers();
        }

        private void reload_Click(object sender, EventArgs e)
        {
        }

        private void gridUsers_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

            if (e.ColumnIndex.Equals(4) && !e.RowIndex.Equals(-1))
            {
                lblValidation.Text = string.Empty;
                UserEdit u = UserController.Instance.GetUserEdit(gridUsers.Rows[e.RowIndex].Cells["username"].Value.ToString());
                if (u != null)
                {
                    userToEdit = u;
                    tbNewEmail.Text = u.Email;
                    tbNewUsername.Text = u.UserName;
                    tbNewPassword.Text = string.Empty;
                    tbNewRepeatPassword.Text = string.Empty;
                    btnUpdate.Enabled = true;
                    btnAddUser.Enabled = false;
                    btnCancelEdit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("U퓓tkownik nie istnieje!");
                    FillWithUsers();
                }
            }
            else if (e.ColumnIndex.Equals(5) && !e.RowIndex.Equals(-1))
            {
               if( MessageBox.Show ("Czy chcesz usun방 u퓓tkownika?", "Usuwanie u퓓tkownika",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question).Equals(DialogResult.Yes));
                {
                    if (!UserController.Instance.DeleteUser(gridUsers.Rows[e.RowIndex].Cells["username"].Value.ToString()))
                        MessageBox.Show("Nie mo퓆a usun방");
                    gridUsers.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void pages_SelectedPageChanged(object sender, EventArgs e)
        {
            if (pages.TabIndex == 15)
                FillWithUsers();
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            new Faculties().ShowDialog();
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
             new Departaments().ShowDialog();
        }

        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            new Institutes().ShowDialog();
        }

        private void radButtonElement4_Click(object sender, EventArgs e)
        {

            
        }
    }
}
