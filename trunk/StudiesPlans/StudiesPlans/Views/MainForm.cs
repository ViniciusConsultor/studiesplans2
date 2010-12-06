using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using StudiesPlansModels.Models;
using StudiesPlans.Controllers;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using StudiesPlans.Pdf;
using StudiesPlans.Xml;
using Telerik.WinControls.UI;
namespace StudiesPlans.Views
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private UserEdit userToEdit = null;
        private User logged = null;
        public static Plan LoadedPlan = null;
        PdfPage page = new PdfPage();
        public static Plan ArchivedPlan = null;
        public List<string> types = null;

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

            if(types!= null)
                foreach (string type in types)
                {
                    gridPlanSubjects.Columns.Remove(type);
                    gridArchievePlan.Columns.Remove(type);
                }

            if (subjectTypes != null)
            {
                if (types == null)
                    types = new List<string>();

                types.Clear();
                foreach (SubjectType s in subjectTypes)
                {
                    types.Add(s.Name);
                    //gridPlanSubjects.Columns.Remove(s.Name);
                    //gridArchievePlan.Columns.Remove(s.Name);
                    gridPlanSubjects.Columns.Add(s.Name, s.Name);
                    gridArchievePlan.Columns.Add(s.Name, s.Name);
                    Telerik.WinControls.UI.GridViewDataColumn col = gridPlanSubjects.Columns[s.Name];
                    col.Width = 100;
                    col.AutoSizeMode = Telerik.WinControls.UI.BestFitColumnMode.DisplayedDataCells;
                    col = gridArchievePlan.Columns[s.Name];
                    col.Width = 100;
                    col.AutoSizeMode = Telerik.WinControls.UI.BestFitColumnMode.DisplayedDataCells;
                }
            }
        }

        private void ManageUsers(User user)
        {
            bool wasPlan = false;
            bool disableButtons = true;
            for (int i = 0; i < user.Role.Privilages.Count(); i++)
            {
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Edycja"))
                {
                    if (wasPlan == false)
                    {
                        pages.Pages.Add(plancreate);
                        wasPlan = true;
                        disableButtons = false;
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

            if (disableButtons)
                DisableToolbarButtons();
        }

        private void DisableToolbarButtons()
        {
            btnDepMngmt.Enabled = false;
            btnFacMnmgt.Enabled = false;
            btnInstMnmgt.Enabled = false;
            btnSemMnmgt.Enabled = false;
            btnSpecMnmgt.Enabled = false;
            btnStuMnmgt.Enabled = false;
            btnSubTMnmgt.Enabled = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region Users

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
                
                if (cbRoles.Items.Count > 0)
                    cbRoles.SelectedIndex = 0;
            }
        }

        private bool EditUser(UserEdit u)
        {
            string errors = string.Empty;
            lblValidation.Text = "";
            u.ClearErrors();
            if (u != null)
            {
                u.UserName = tbNewUsername.Text;
                u.Password = tbNewPassword.Text;
                u.RepeatPassword = tbNewRepeatPassword.Text;
                u.Email = tbNewEmail.Text;

                int roleId = RoleController.Instance.GetRoleId(cbRoles.SelectedItem.ToString());
                if (roleId > 0)
                    u.RoleID = roleId;

                if (!UserController.Instance.UpdateUser(u))
                {
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

        private void gridUsers_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

            if (e.Column.Name.Equals("editUserColumn") && !e.RowIndex.Equals(-1))
            {
                lblValidation.Text = string.Empty;
                UserEdit u = UserController.Instance.GetUserEdit(gridUsers.Rows[e.RowIndex].Cells["usernameColumn"].Value.ToString());
                if (u != null)
                {
                    userToEdit = u;

                    Role r = RoleController.Instance.GetRole(u.RoleID);
                    if (r != null)
                    {
                        int index = 0;
                        foreach (string role in cbRoles.Items)
                        {
                            if (!role.ToLower().Equals(r.Name.ToLower()))
                                index++;
                            else
                                break;
                        }

                        cbRoles.SelectedIndex = index;
                    }

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
                if(RadMessageBox.Show ("Czy chcesz usun¹æ u¿ytkownika?", "Usuwanie u¿ytkownika",
                   MessageBoxButtons.YesNo, RadMessageIcon.Question).Equals(DialogResult.Yes))
                {
                    if (!gridUsers.Rows[e.RowIndex].Cells["usernameColumn"].Value.ToString().Equals(logged.Name))
                    {
                        if (!UserController.Instance.DeleteUser(gridUsers.Rows[e.RowIndex].Cells["usernameColumn"].Value.ToString()))
                            RadMessageBox.Show("Nie mo¿na usun¹æ", "B³¹d");
                        else
                        {
                            gridUsers.Rows.RemoveAt(e.RowIndex);
                            Clear();
                            btnUpdate.Enabled = false;
                            btnAddUser.Enabled = true;
                            btnCancelEdit.Enabled = false;
                        }
                    }
                    else
                        RadMessageBox.Show("Nie mo¿na usun¹æ w³asnego u¿ytkownika!", "B³¹d");
                }
            }
        }

        private void pages_SelectedPageChanged(object sender, EventArgs e)
        {
            if (pages.TabIndex == 15)
                FillWithUsers();
        }

        #endregion

        #region Plans

        private void btnNewPlan_Click(object sender, EventArgs e)
        {
            if (new Plans(logged).ShowDialog() == DialogResult.Yes && LoadedPlan != null)
                LoadPlanToGrid(LoadedPlan, false);               
        }

        private void btnLoadPlan_Click(object sender, EventArgs e)
        {
            Plan oldPlan = LoadedPlan;
            new PlansLoad(false).ShowDialog();
            if ((oldPlan != null && oldPlan.PlanID != LoadedPlan.PlanID) || (oldPlan == null && LoadedPlan != null))
            {
                LoadPlanToGrid(LoadedPlan, false);
            }
        }

        private void LoadPlanToGrid(Plan LoadedPlan, bool archive)
        {
            RadGridView grid = null;
            if (!archive)
                grid = gridPlanSubjects;
            else
                grid = gridArchievePlan;

            lblPlanData.Text = "Plan: " + LoadedPlan.Name + " Wydzia³: " + LoadedPlan.Departament.Name + " Kierunek: "
                + LoadedPlan.Faculty.Name + " Studia: " + LoadedPlan.StudiesType.Name;
            
            grid.Rows.Clear();
            grid.EnableSorting = false;
            if (LoadedPlan.SubjectsDatas != null)
            {
                foreach (SubjectsData sd in LoadedPlan.SubjectsDatas)
                {
                    grid.Rows.Add(null, null);
                    grid.Rows[grid.Rows.Count - 1].Cells["subjectName"].Value = sd.Subject.Name;
                    grid.Rows[grid.Rows.Count - 1].Cells["semester"].Value = sd.Semester.Name;
                    grid.Rows[grid.Rows.Count - 1].Cells["ects"].Value = sd.Ects.ToString();
                    grid.Rows[grid.Rows.Count - 1].Cells["isExam"].Value = sd.IsExam;
                    grid.Rows[grid.Rows.Count - 1].Cells["isGeneral"].Value = sd.IsGeneral;
                    grid.Rows[grid.Rows.Count - 1].Cells["isElective"].Value = sd.IsElective;
                    grid.Rows[grid.Rows.Count - 1].Cells["institute"].Value = sd.Institute == null ? "Brak" : sd.Institute.Name;

                    if (sd.SpecializationDataID > 0)
                    {
                        string value = sd.SpecializationsData.Specialization.Name;
                        if (sd.SpecializationsData.IsElective)
                            value += " Obieralny";
                        else if (sd.SpecializationsData.IsGeneral)
                            value += " Obowi¹zkowy";
                        grid.Rows[grid.Rows.Count - 1].Cells["specialization"].Value = value;
                    }

                    foreach (SubjectTypesData st in sd.SubjectTypesDatas)
                    {
                        grid.Rows[grid.Rows.Count - 1].Cells[st.SubjectType.Name].Value = st.Hours.ToString();
                    }
                }

            }
            grid.EnableSorting = true;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (LoadedPlan != null)
            {
                if (new Subjects(LoadedPlan).ShowDialog() == DialogResult.Yes)
                    CreateSubjectGrid();
                LoadPlanToGrid(LoadedPlan, false);
            }
        }

        private SubjectEdit CreateSubjectEditFromGrid()
        {
            if (LoadedPlan != null && gridPlanSubjects.Rows.Count > 0)
            {
                int row = gridPlanSubjects.SelectedRows.ElementAt(0).Index;

                Semester sem = SemesterController.Instance.GetSemester(gridPlanSubjects.Rows[row].Cells["semester"].Value.ToString());
                int semId = sem == null ? 0 : sem.SemesterID;

                SubjectEdit ns = new SubjectEdit()
                {
                    Departament = LoadedPlan.Departament.Name,
                    Faculty = LoadedPlan.Faculty.Name,
                    Institute = gridPlanSubjects.Rows[row].Cells["institute"].Value.ToString().Equals("Brak") ? null : gridPlanSubjects.Rows[row].Cells["institute"].Value.ToString(),
                    Ects = Convert.ToDouble(gridPlanSubjects.Rows[row].Cells["ects"].Value),
                    IsExam = Convert.ToBoolean(gridPlanSubjects.Rows[row].Cells["isExam"].Value),
                    Name = gridPlanSubjects.Rows[row].Cells["subjectName"].Value.ToString(),
                    PlanId = LoadedPlan.PlanID,
                    SemesterId = semId,
                    IsGeneral = Convert.ToBoolean(gridPlanSubjects.Rows[row].Cells["isGeneral"].Value),
                    IsElective = Convert.ToBoolean(gridPlanSubjects.Rows[row].Cells["isElective"].Value)
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

            return null;
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (LoadedPlan != null)
            {
                SubjectEdit ns = CreateSubjectEditFromGrid();

                if (SubjectController.Instance.DeleteSubject(ns))
                {
                    LoadedPlan = PlanController.Instance.GetPlan(LoadedPlan.PlanID);
                    LoadPlanToGrid(LoadedPlan, false);
                }
            }
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            if (LoadedPlan != null)
            {
                SubjectEdit ns = CreateSubjectEditFromGrid();
                if (ns != null)
                {
                    if (new EditSubject(LoadedPlan, ns).ShowDialog() == DialogResult.Yes)
                    {
                        LoadedPlan = PlanController.Instance.GetPlan(LoadedPlan.PlanID);
                        LoadPlanToGrid(LoadedPlan, false);
                    }
                }
            }
        }

        #endregion

        #region ToolBar

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

        #endregion

        #region Preview

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoadedPlan != null)
            {
                RenderPdf render = new RenderPdf();
                render.LoadedPlan = LoadedPlan;
                pagePreview1.SetRenderEvent(render.Render);
                PdfDocument pdf = new PdfDocument();
                page = pdf.AddPage();
                page.Orientation = PdfSharp.PageOrientation.Landscape;
                XGraphics gfx = XGraphics.FromPdfPage(page);
                render.Render(gfx);
                page.Width = new XUnit(render.Width);
                pdf.Save(@"C:\first.pdf");
                pagePreview1.PageSize = new XSize(render.Width, pagePreview1.PageSize.Height);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int zoom = 0;
            int.TryParse(textBox1.Text, out zoom);
            pagePreview1.ZoomPercent = zoom;
        }

        #endregion

        #region Archive

        private void button3_Click(object sender, EventArgs e)
        {
            XmlPlan plantToXml = new XmlPlan(LoadedPlan);
            plantToXml.CreateXmlDocument();
            plantToXml.SaveXmlDocument(@"C:\text.xml");
        }

        private void btnLoadArchivePlan_Click(object sender, EventArgs e)
        {
            Plan oldPlan = ArchivedPlan;
            new PlansLoad(true).ShowDialog();
            if ((oldPlan != null && oldPlan.PlanID != ArchivedPlan.PlanID) || (oldPlan == null && ArchivedPlan != null))
            {
                LoadPlanToGrid(ArchivedPlan, true);
            }
        }

        private void CopyFromArchive()
        {
            if (ArchivedPlan != null)
            {
                PlanController.Instance.CopyArchivePlan(ArchivedPlan.PlanID, LoadedPlan.PlanID);
            }
            else
            {
                RadMessageBox.Show("Nale¿y wybraæ plan archiwalny", "B³¹d");
            }
        }

        private void btnCopyArchivePlan_Click(object sender, EventArgs e)
        {
            if (LoadedPlan != null && ArchivedPlan != null)
                CopyFromArchive();
        }

        #endregion
    }
}
