using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudiesPlans.Views;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;
using StudiesPlans.Controllers;

namespace StudiesPlans
{
    public partial class MainForm : Form
    {
        UserEdit userToEdit = null;
        public MainForm(User user)
        {
            InitializeComponent();
            pages.TabPages.Remove(subjects);
            pages.TabPages.Remove(plancreate);
            pages.TabPages.Remove(review);
            pages.TabPages.Remove(archive);
            pages.TabPages.Remove(users);
            ManageUsers(user);
        }

        private void ManageUsers(User user)
        {
            bool wasPlan = false;
            for(int i = 0; i < user.Role.Privilages.Count(); i++)
            {
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Edycja"))
                {
                    pages.TabPages.Add(subjects);
                    if (wasPlan == false)
                    {
                        pages.TabPages.Add(plancreate);
                        wasPlan = true;
                    }
                }
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Recenzowanie") && wasPlan == false)
                    pages.TabPages.Add(plancreate);
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Przeglądanie"))
                    pages.TabPages.Add(review);
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Archiwizacja"))
                    pages.TabPages.Add(archive);
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Użytkownicy"))
                    pages.TabPages.Add(users);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Brush _TextBrush;

            TabPage _TabPage = pages.TabPages[e.Index];
            Rectangle _TabBounds = pages.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Kolor tekstu i zaznaczenia zakładki
                _TextBrush = new SolidBrush(Color.Black);
                graphics.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _TextBrush = new System.Drawing.SolidBrush(Color.Black);
                graphics.FillRectangle(Brushes.Silver, e.Bounds);
            }

            // Ustawienie własnej czcionki
            Font _TabFont = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);

            // Wypisanie tekstu, wyjustowanie
            StringFormat _StringFlags = new StringFormat();
            _StringFlags.Alignment = StringAlignment.Center;
            _StringFlags.LineAlignment = StringAlignment.Center;
            graphics.DrawString(_TabPage.Text, _TabFont, _TextBrush,
                         _TabBounds, new StringFormat(_StringFlags));

        }

        private void pages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pages.SelectedIndex == 4)
                FillWithUsers();
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

                    gridUsers.Rows.Add(u.Name, email, lastActiveDate, u.Role.Name);
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

        private void gridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
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
                    MessageBox.Show("Użytkownik nie istnieje!");
                    FillWithUsers();
                }
            }
            else if (e.ColumnIndex == 5)
            {
                if (!UserController.Instance.DeleteUser(gridUsers.Rows[e.RowIndex].Cells["username"].Value.ToString()))
                    MessageBox.Show("Nie można usunąć");
                gridUsers.Rows.RemoveAt(e.RowIndex);
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
            IEnumerable<SubjectsData> subjects = SubjectController.Instance.ListSubjects();
            if (subjects != null)
                foreach (SubjectsData subject in subjects)
                    gridSubjects.Rows.Add(subject.Subject.Name, subject.Ects, subject.Semester.Semester1, subject.Faculty.Name, subject.Departament.Name);
        }

        private void facultymngmt_Click(object sender, EventArgs e)
        {
            new Faculties().ShowDialog();
        }

        private void departamentmngmt_Click(object sender, EventArgs e)
        {
            new Departaments().ShowDialog();
        }

        private void institutesmngmt_Click(object sender, EventArgs e)
        {
            new Institutes().ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new Specializations().ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new SubjectTypes().ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            new Semesters().ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            new StudiesTypes().ShowDialog();
        }
    }
}
