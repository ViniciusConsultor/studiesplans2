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

        public static Plan PreviewPlan = null;
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
            FillZoom();
            SetButtonsToolTips();
        }

        private void CreateSubjectGrid()
        {
            List<SubjectType> subjectTypes = SubjectTypeController.Instance.ListSubjectTypes().ToList<SubjectType>();

            if(types!= null)
                foreach (string type in types)
                {
                    btnVerify.Columns.Remove(type);
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
                    btnVerify.Columns.Add(s.Name, s.Name);
                    gridArchievePlan.Columns.Add(s.Name, s.Name);
                    Telerik.WinControls.UI.GridViewDataColumn col = btnVerify.Columns[s.Name];
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
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Przegl�danie"))
                    pages.Pages.Add(review);
                if (user.Role.Privilages.ElementAt(i).Name.Equals("Archiwizacja"))
                    pages.Pages.Add(archive);
                if (user.Role.Privilages.ElementAt(i).Name.Equals("U�ytkownicy"))
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

        private void SetButtonsToolTips()
        {
            btnAddSubject.ButtonElement.ToolTipText = "Dodaj przedmiot do planu";
            btnAddUser.ButtonElement.ToolTipText = "Dodaj u�ytkownika";
            btnArchieveInfo.ButtonElement.ToolTipText = "Informacje o planie";
            btnCancelEdit.ButtonElement.ToolTipText = "Anuluj edycj�";
            btnCopyArchivePlan.ButtonElement.ToolTipText = "Kopiuj zarchwizowany plan";
            btnDeleteSubject.ButtonElement.ToolTipText = "Usu� przedmiot z planu";
            btnEditInfo.ButtonElement.ToolTipText = "Informacje o planie";
            btnEditSubject.ButtonElement.ToolTipText = "Edytuj przedmiot";
            btnExportPdf.ButtonElement.ToolTipText = "Zapisz plan jako PDF";
            btnExportXML.ButtonElement.ToolTipText = "Zapisz plan jako XML";
            btnLoadArchivePlan.ButtonElement.ToolTipText = "Wczytaj zarchiwizowany plan";
            btnLoadPlan.ButtonElement.ToolTipText = "Wczytaj plan";
            btnNewPlan.ButtonElement.ToolTipText = "Stw�rz nowy plan";
            btnPlanEdit.ButtonElement.ToolTipText = "Edytuj plan";
            btnRolesMngmt.ButtonElement.ToolTipText = "Zarz�dzaj rolami";
            btnShowPreview.ButtonElement.ToolTipText = "Wczytaj plan";
            btnUpdate.ButtonElement.ToolTipText = "Zapisz zmiany";
            btnPreviewInfo.ButtonElement.ToolTipText = "Informacje o planie";
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
                btnAddUser.Enabled = false;
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
                        foreach (object role in cbRoles.Items)
                        {
                            if (!role.ToString().ToLower().Equals(r.Name.ToLower()))
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
                    btnAddUser.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnCancelEdit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("U�ytkownik nie istnieje!");
                    FillWithUsers();
                }
            }
            else if (e.Column.Name.Equals("deleteUserColumn") && !e.RowIndex.Equals(-1))
            {
                if(RadMessageBox.Show ("Czy chcesz usun�� u�ytkownika?", "Usuwanie u�ytkownika",
                   MessageBoxButtons.YesNo, RadMessageIcon.Question).Equals(DialogResult.Yes))
                {
                    if (!gridUsers.Rows[e.RowIndex].Cells["usernameColumn"].Value.ToString().Equals(logged.Name))
                    {
                        if (!UserController.Instance.DeleteUser(gridUsers.Rows[e.RowIndex].Cells["usernameColumn"].Value.ToString()))
                            RadMessageBox.Show("Nie mo�na usun��", "B��d");
                        else
                        {
                            gridUsers.Rows.RemoveAt(e.RowIndex);
                            Clear();
                            btnAddUser.Enabled = true;
                            btnUpdate.Enabled = false;
                            btnCancelEdit.Enabled = false;
                        }
                    }
                    else
                        RadMessageBox.Show("Nie mo�na usun�� w�asnego u�ytkownika!", "B��d");
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

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            if (LoadedPlan != null)
                new PlanInfo(LoadedPlan).ShowDialog();
            else
                RadMessageBox.Show("Wczytaj plan", "Wiadomo��");
        }

        private void btnNewPlan_Click(object sender, EventArgs e)
        {
            if (new Plans(logged).ShowDialog() == DialogResult.Yes && LoadedPlan != null)
                LoadPlanToGrid(LoadedPlan, false);               
        }

        private void btnPlanEdit_Click(object sender, EventArgs e)
        {
            if (LoadedPlan != null)
                new PlanEdit(LoadedPlan).ShowDialog();
        }

        private void btnLoadPlan_Click(object sender, EventArgs e)
        {
            Plan oldPlan = LoadedPlan;
            new PlansLoad(false, false).ShowDialog();
            if ((oldPlan != null && oldPlan.PlanID != LoadedPlan.PlanID) || (oldPlan == null && LoadedPlan != null))
            {
                LoadPlanToGrid(LoadedPlan, false);
            }
        }

        private void LoadPlanToGrid(Plan LoadedPlan, bool archive)
        {
            RadGridView grid = null;
            if (!archive)
                grid = btnVerify;
            else
                grid = gridArchievePlan;

            if(!archive)
                lblPlanData.Text = "Plan: " + LoadedPlan.Name + " Wydzia�: " + LoadedPlan.Departament.Name + " Kierunek: "
                    + LoadedPlan.Faculty.Name + " Studia: " + LoadedPlan.StudiesType.Name;
            else
                lblArchievedPlanData.Text = "Plan: " + LoadedPlan.Name + " Wydzia�: " + LoadedPlan.Departament.Name + " Kierunek: "
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
                            value += " Obowi�zkowy";
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
            if (LoadedPlan != null && btnVerify.Rows.Count > 0)
            {
                int row = btnVerify.SelectedRows.ElementAt(0).Index;

                Semester sem = SemesterController.Instance.GetSemester(btnVerify.Rows[row].Cells["semester"].Value.ToString());
                int semId = sem == null ? 0 : sem.SemesterID;

                SubjectEdit ns = new SubjectEdit()
                {
                    Departament = LoadedPlan.Departament.Name,
                    Faculty = LoadedPlan.Faculty.Name,
                    Institute = btnVerify.Rows[row].Cells["institute"].Value.ToString().Equals("Brak") ? null : btnVerify.Rows[row].Cells["institute"].Value.ToString(),
                    Ects = Convert.ToDouble(btnVerify.Rows[row].Cells["ects"].Value),
                    IsExam = Convert.ToBoolean(btnVerify.Rows[row].Cells["isExam"].Value),
                    Name = btnVerify.Rows[row].Cells["subjectName"].Value.ToString(),
                    PlanId = LoadedPlan.PlanID,
                    SemesterId = semId,
                    IsGeneral = Convert.ToBoolean(btnVerify.Rows[row].Cells["isGeneral"].Value),
                    IsElective = Convert.ToBoolean(btnVerify.Rows[row].Cells["isElective"].Value)
                };

                if (btnVerify.Rows[row].Cells["specialization"].Value != null
                    && !btnVerify.Rows[row].Cells["specialization"].Value.ToString().Equals(string.Empty))
                {
                    string name = GetSpecializationFromGrid(btnVerify.Rows[row].Cells["specialization"].Value.ToString());
                    
                    SpecializationEdit se = SpecializationController.Instance.GetSpecializationEdit(name, LoadedPlan.Departament.Name, LoadedPlan.Faculty.Name);

                    if (se!= null)
                    {
                        bool general = GetBoolFromGrid(btnVerify.Rows[row].Cells["specialization"].Value.ToString(), true, false);
                        bool elective = GetBoolFromGrid(btnVerify.Rows[row].Cells["specialization"].Value.ToString(), false, true);
                        
                        SpecializationDataEdit nsd = SpecializationController.Instance.GetSpecializationDataEdit(name, LoadedPlan.PlanID, general, elective, ns.Name, sem.Semester1);

                        List<SpecializationDataEdit> listnsd = new List<SpecializationDataEdit>();
                        listnsd.Add(nsd);
                        ns.Specializations = listnsd.AsEnumerable();
                    }
                }

                List<NewSubjectTypeData> nstdlist = new List<NewSubjectTypeData>();
                List<SubjectType> list = SubjectTypeController.Instance.ListSubjectTypes();
                for (int i = 0; i < list.Count; i++)
                {
                    if (btnVerify.Rows[row].Cells[list.ElementAt(i).Name].Value != null
                        && !btnVerify.Rows[row].Cells[list.ElementAt(i).Name].Value.ToString().Equals(string.Empty))
                    {
                        NewSubjectTypeData nstd = new NewSubjectTypeData()
                        {
                            Hours = Convert.ToInt32(btnVerify.Rows[row].Cells[list.ElementAt(i).Name].Value),
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

        private bool GetBoolFromGrid(string stringValue, bool general, bool elective)
        {
            if (stringValue.ToLower().Contains("obowi�zkowy") && general)
                return true;

            if (stringValue.ToLower().Contains("obieralny") && elective)
                return true;

            return false;
        }

        private string GetSpecializationFromGrid(string spec)
        {
            int index = 0;
            if (spec.ToLower().Contains("obowi�zkowy"))
            {
                index = spec.ToLower().IndexOf("obowi�zkowy");
                return spec.Substring(0, index - 1);
            }
            else if (spec.ToLower().Contains("obieralny"))
            {
                index = spec.ToLower().IndexOf("obieralny");
                return spec.Substring(0, index - 1);
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
                    btnVerify.Columns.Remove(st.Name);
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

        private void FillZoom()
        {
            for (int i = 25; i <= 800; i += 25)
                dlZoom.Items.Add(i.ToString());
            dlZoom.SelectedIndex = 3;
        }

        private void btnShowPreview_Click(object sender, EventArgs e)
        {
            new PlansLoad(false, true).ShowDialog();
            if (PreviewPlan != null)
            {
                RenderPdf render = new RenderPdf();
                render.LoadedPlan = PreviewPlan;
                pagePreview1.SetRenderEvent(render.Render);
                PdfDocument pdf = new PdfDocument();
                page = pdf.AddPage();
                page.Orientation = PdfSharp.PageOrientation.Landscape;
                XGraphics gfx = XGraphics.FromPdfPage(page);
                render.Render(gfx);
                page.Width = new XUnit(render.Width);
                pagePreview1.PageSize = new XSize(render.Width, pagePreview1.PageSize.Height);
            }
        }

        private void dlZoom_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            int zoom = 0;
            int.TryParse(dlZoom.SelectedItem.ToString(), out zoom);
            pagePreview1.ZoomPercent = zoom;
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (PreviewPlan != null && dlgSavePdf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RenderPdf render = new RenderPdf();
                render.LoadedPlan = PreviewPlan;
                PdfDocument pdf = new PdfDocument();
                page = pdf.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                render.Render(gfx);
                page.Width = new XUnit(render.Width);
                pdf.Save(dlgSavePdf.FileName);
            }
            else if(PreviewPlan == null)
                RadMessageBox.Show("Wczytaj plan", "Wiadomo��");
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            if (PreviewPlan != null && dlgSaveXml.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlPlan plantToXml = new XmlPlan(PreviewPlan);
                plantToXml.CreateXmlDocument();
                plantToXml.SaveXmlDocument(dlgSaveXml.FileName);
            }
            else if (PreviewPlan == null)
                RadMessageBox.Show("Wczytaj plan", "Wiadomo��");
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (PreviewPlan != null)
                new PlanInfo(PreviewPlan).ShowDialog();
            else
                RadMessageBox.Show("Wczytaj plan", "Wiadomo��");
        }

        #endregion

        #region Archive

        private void btnArchieveInfo_Click(object sender, EventArgs e)
        {
            if (ArchivedPlan != null)
                new PlanInfo(ArchivedPlan).ShowDialog();
            else
                RadMessageBox.Show("Wczytaj plan", "Wiadomo��");
        }

        private void btnLoadArchivePlan_Click(object sender, EventArgs e)
        {
            Plan oldPlan = ArchivedPlan;
            new PlansLoad(true, false).ShowDialog();
            if ((oldPlan != null && oldPlan.PlanID != ArchivedPlan.PlanID) || (oldPlan == null && ArchivedPlan != null))
                LoadPlanToGrid(ArchivedPlan, true);
        }

        private void CopyFromArchive()
        {
            if (ArchivedPlan != null)
            {
                PlanController.Instance.CopyArchivePlan(ArchivedPlan.PlanID, LoadedPlan.PlanID);
                LoadPlanToGrid(LoadedPlan, false);
            }
            else
                RadMessageBox.Show("Nale�y wybra� plan archiwalny", "B��d");
        }

        private void btnCopyArchivePlan_Click(object sender, EventArgs e)
        {
            if (LoadedPlan != null && ArchivedPlan != null)
                CopyFromArchive();
        }

        #endregion

        private void radButtonElement7_Click_1(object sender, EventArgs e)
        {
            if (LoadedPlan != null)
            {
                new Rules(LoadedPlan).ShowDialog();
            }
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            if (LoadedPlan != null)
            {
                new Rules(LoadedPlan).ShowDialog();
            }
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            if (LoadedPlan != null)
                new Rules(LoadedPlan).ShowDialog();
        }

        private void radButtonElement7_Click_2(object sender, EventArgs e)
        {
            if (LoadedPlan != null)
                new ValidateRules(LoadedPlan).ShowDialog();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            if (LoadedPlan != null)
                new Rules(LoadedPlan).ShowDialog();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (LoadedPlan != null)
                new ValidateRules(LoadedPlan).ShowDialog();
        }

    }
}
