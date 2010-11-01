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
        private UserEdit userToEdit = null;
        private User logged = null;
        public static Plan LoadedPlan = null;

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
            logged = user;
            CreateSubjectGrid();
        }

        private void CreateSubjectGrid()
        {
            List<SubjectType> subjectTypes = SubjectTypeController.Instance.ListSubjectTypes().ToList<SubjectType>();
            if (subjectTypes != null)
                foreach (SubjectType s in subjectTypes)
                {
                    gridPlanSubjects.Columns.Add(s.Name, s.Name);
                    Telerik.WinControls.UI.GridViewDataColumn col = gridPlanSubjects.Columns[s.Name];
                    col.Width = 100;
                    col.AutoSizeMode = Telerik.WinControls.UI.BestFitColumnMode.DisplayedDataCells;
                }

           // gridPlanSubjects.AutoSizeRows = true;
           // gridPlanSubjects.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
           // gridPlanSubjects.AutoSize = true;
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
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Przegl¹danie"))
                    pages.Pages.Add(review);
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Archiwizacja"))
                    pages.Pages.Add(archive);
                if (user.Role.Privilages.ElementAt(i).Name.Equals("U¿ytkownicy"))
                    pages.Pages.Add(users);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //private void updateGUI()
        //{
        //    Application.DoEvents();
        //    this.Invalidate();
        //    this.Update();
        //    System.Threading.Thread.Sleep(1);
        //}

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

                    gridUsers.Rows.Add(null, null);

                    gridUsers.Rows[gridUsers.Rows.Count - 1].Cells["usernameColumn"].Value = u.Name;
                    gridUsers.Rows[gridUsers.Rows.Count - 1].Cells["emailColumn"].Value = email;
                    gridUsers.Rows[gridUsers.Rows.Count - 1].Cells["lastLoginColumn"].Value = lastActiveDate;
                    gridUsers.Rows[gridUsers.Rows.Count - 1].Cells["roleColumn"].Value = u.Role.Name;
                    gridUsers.Rows[gridUsers.Rows.Count - 1].Cells["editUserColumn"].Value = Properties.Resources.edit;
                    gridUsers.Rows[gridUsers.Rows.Count - 1].Cells["deleteUserColumn"].Value = Properties.Resources.delete;          
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

            if (e.Column.Name.Equals("editUserColumn") && !e.RowIndex.Equals(-1))
            {
                lblValidation.Text = string.Empty;
                UserEdit u = UserController.Instance.GetUserEdit(gridUsers.Rows[e.RowIndex].Cells["usernameColumn"].Value.ToString());
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
                    MessageBox.Show("U¿ytkownik nie istnieje!");
                    FillWithUsers();
                }
            }
            else if (e.Column.Name.Equals("deleteUserColumn") && !e.RowIndex.Equals(-1))
            {
               if( MessageBox.Show ("Czy chcesz usun¹æ u¿ytkownika?", "Usuwanie u¿ytkownika",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    if (!UserController.Instance.DeleteUser(gridUsers.Rows[e.RowIndex].Cells["usernameColumn"].Value.ToString()))
                        MessageBox.Show("Nie mo¿na usun¹æ");
                    else
                    {
                        gridUsers.Rows.RemoveAt(e.RowIndex);
                        Clear();
                        btnUpdate.Enabled = false;
                        btnAddUser.Enabled = true;
                        btnCancelEdit.Enabled = false;
                    }
                }
            }
        }

        private void pages_SelectedPageChanged(object sender, EventArgs e)
        {
            if (pages.TabIndex == 15)
                FillWithUsers();
        }

        private void btnNewPlan_Click(object sender, EventArgs e)
        {
            if (new Plans(logged).ShowDialog() == DialogResult.Yes
                && LoadedPlan != null)
                LoadPlanToGrid(LoadedPlan);               
        }

        private void btnLoadPlan_Click(object sender, EventArgs e)
        {
            Plan oldPlan = LoadedPlan;
            new PlansLoad().ShowDialog();
            if ((oldPlan != null && oldPlan.PlanID != LoadedPlan.PlanID) || (oldPlan == null && LoadedPlan != null))
            {
                LoadPlanToGrid(LoadedPlan);
            }
        }

        private void LoadPlanToGrid(Plan LoadedPlan)
        {
            lblPlanData.Text = "Plan: " + LoadedPlan.Name + " Wydzia³: " + LoadedPlan.Departament.Name + " Kierunek: "
                + LoadedPlan.Faculty.Name + " Studia: " + LoadedPlan.StudiesType.Name;
            
            gridPlanSubjects.Rows.Clear();
            gridPlanSubjects.EnableSorting = false;
            if (LoadedPlan.SubjectsDatas != null)
            {
                foreach (SubjectsData sd in LoadedPlan.SubjectsDatas)
                {
                    gridPlanSubjects.Rows.Add(null, null);
                    gridPlanSubjects.Rows[gridPlanSubjects.Rows.Count - 1].Cells["subjectName"].Value = sd.Subject.Name;
                    gridPlanSubjects.Rows[gridPlanSubjects.Rows.Count - 1].Cells["semester"].Value = sd.Semester.Name;
                    gridPlanSubjects.Rows[gridPlanSubjects.Rows.Count - 1].Cells["ects"].Value = sd.Ects.ToString();
                    gridPlanSubjects.Rows[gridPlanSubjects.Rows.Count - 1].Cells["isExam"].Value = sd.IsExam;
                    gridPlanSubjects.Rows[gridPlanSubjects.Rows.Count - 1].Cells["isGeneral"].Value = sd.IsGeneral;
                    gridPlanSubjects.Rows[gridPlanSubjects.Rows.Count - 1].Cells["isElective"].Value = sd.IsElective;
                    gridPlanSubjects.Rows[gridPlanSubjects.Rows.Count - 1].Cells["institute"].Value = sd.Institute == null ? "Brak" : sd.Institute.Name;

                    if (sd.SpecializationDataID > 0)
                    {
                        string value = sd.SpecializationsData.Specialization.Name;
                        if (sd.SpecializationsData.IsElective)
                            value += " Obieralny";
                        else if (sd.SpecializationsData.IsGeneral)
                            value += " Obowi¹zkowy";
                        gridPlanSubjects.Rows[gridPlanSubjects.Rows.Count - 1].Cells["specialization"].Value = value;
                    }

                    foreach (SubjectTypesData st in sd.SubjectTypesDatas)
                    {
                        gridPlanSubjects.Rows[gridPlanSubjects.Rows.Count - 1].Cells[st.SubjectType.Name].Value = st.Hours.ToString();
                    }
                }

            }
            gridPlanSubjects.EnableSorting = true;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (LoadedPlan != null)
            {
                new Subjects(LoadedPlan).ShowDialog();
                LoadPlanToGrid(LoadedPlan);
            }
        }

        private SubjectEdit CreateSubjectEditFromGrid()
        {
            int row = gridPlanSubjects.SelectedRows.ElementAt(0).Index;

            Semester sem = SemesterController.Instance.GetSemester(gridPlanSubjects.Rows[row].Cells["semester"].Value.ToString());
            int semId = sem == null ? 0 : sem.SemesterID;

            SubjectEdit ns = new SubjectEdit()
            {
                Departament = LoadedPlan.Departament.Name,
                Faculty = LoadedPlan.Faculty.Name,
                Institute = gridPlanSubjects.Rows[row].Cells["institute"].Value.ToString(),
                Ects = Convert.ToDouble(gridPlanSubjects.Rows[row].Cells["ects"].Value),
                IsExam = Convert.ToBoolean(gridPlanSubjects.Rows[row].Cells["isExam"].Value),
                Name = gridPlanSubjects.Rows[row].Cells["subjectName"].Value.ToString(),
                PlanId = LoadedPlan.PlanID,
                SemesterId = semId
            };

            List<NewSubjectTypeData> nstdlist = new List<NewSubjectTypeData>();
            List<SubjectType> list = SubjectTypeController.Instance.ListSubjectTypes();
            for (int i = 0; i < list.Count; i++)
            {
                if (gridPlanSubjects.Rows[row].Cells[list.ElementAt(i).Name].Value != null
                    && !gridPlanSubjects.Rows[row].Cells[list.ElementAt(i).Name].Value.ToString().Equals(string.Empty))
                {
                    NewSubjectTypeData nstd = new NewSubjectTypeData()
                    {
                        Hours = Convert.ToInt32(gridPlanSubjects.Rows[row].Cells[list.ElementAt(i).Name].Value),
                        SubjectTypeId = list.ElementAt(i).SubjectTypeID
                    };
                    nstdlist.Add(nstd);
                }
            }

            ns.SubjectTypes = nstdlist;

            SubjectsData sd = SubjectController.Instance.GetSubject(ns);
            ns.SubjectId = sd.SubjectDataID;
            return ns;
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            SubjectEdit ns = CreateSubjectEditFromGrid();

            if (SubjectController.Instance.DeleteSubject(ns))
            {
                LoadedPlan = PlanController.Instance.GetPlan(LoadedPlan.PlanID);
                LoadPlanToGrid(LoadedPlan);
            }
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            SubjectEdit ns = CreateSubjectEditFromGrid();

            if (new EditSubject(LoadedPlan, ns).ShowDialog() == DialogResult.Yes)
            {
                LoadedPlan = PlanController.Instance.GetPlan(LoadedPlan.PlanID);
                LoadPlanToGrid(LoadedPlan);
            }
        }

        private void radButtonElement7_Click(object sender, EventArgs e)
        {
            new Departaments().ShowDialog();
        }

        private void radButtonElement8_Click(object sender, EventArgs e)
        {
            new Faculties().ShowDialog();
        }

        private void radButtonElement9_Click(object sender, EventArgs e)
        {
            List<SubjectType> subjectTypes = SubjectTypeController.Instance.ListSubjectTypes().ToList<SubjectType>();

            SPDatabase.DB = null;
            
            if (new SubjectTypes().ShowDialog() == DialogResult.Yes)
            {
                foreach (SubjectType st in subjectTypes)
                    gridPlanSubjects.Columns.Remove(st.Name);
                CreateSubjectGrid();
            }
        }

        private void radButtonElement10_Click(object sender, EventArgs e)
        {
            new StudiesTypes().ShowDialog();
        }

        private void radButtonElement11_Click(object sender, EventArgs e)
        {
            new Institutes().ShowDialog();
        }

        private void radButtonElement12_Click(object sender, EventArgs e)
        {
            new Specializations().ShowDialog();
        }

        private void radButtonElement13_Click(object sender, EventArgs e)
        {
            new Semesters().ShowDialog();
        }
    }
}
