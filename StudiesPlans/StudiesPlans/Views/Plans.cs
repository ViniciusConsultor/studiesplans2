using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using StudiesPlansModels.Models;
using StudiesPlans.Controllers;

namespace StudiesPlans.Views
{
    public partial class Plans : Telerik.WinControls.UI.RadForm
    {
        User loggedUser = null;
        bool added = false;
        Plan addedPlan = null;

        public Plans(User user)
        {
            InitializeComponent();
            FillWithDepartaments();
            FillWithFaculties();
            FillWithStudiesTypes();
            loggedUser = user;
        }

        private void FillWithStudiesTypes()
        {
            cbStudiesType.Items.Clear();
            IEnumerable<StudiesType> studiesTypes = StudiesTypeController.Instance.ListStudiesTypes();
            if (studiesTypes != null)
            {
                foreach (StudiesType st in studiesTypes)
                    cbStudiesType.Items.Add(st.Name);
                cbStudiesType.SelectedIndex = 0;
            }
        }

        private void FillWithFaculties()
        {
            cbFaculty.Items.Clear();

            if (cbDepartament.Items.Count > 0)
            {
                Departament dep = DepartamentController.Instance.GetDepartament(cbDepartament.SelectedItem.ToString());

                if (dep != null)
                {
                    List<Faculty> faculties = FacultyController.Instance.ListFaculties(dep.DepartamentID);

                    if (faculties != null)
                        foreach (Faculty f in faculties)
                            cbFaculty.Items.Add(f.Name);
                    cbFaculty.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Wybrany wydzia³ nie istnieje");
                    FillWithDepartaments();
                }
            }
        }

        private void FillWithDepartaments()
        {
            cbDepartament.Items.Clear();
            IEnumerable<Departament> departaments = DepartamentController.Instance.ListDepartaments();
            if (departaments != null)
            {
                foreach (Departament d in departaments)
                    cbDepartament.Items.Add(d.Name);
                cbDepartament.SelectedIndex = 0;
            }
        }

        private void Clear()
        {
            lblValidation.Text = string.Empty;
            tbPlanName.Text = string.Empty;
            tbSemEnd.Text = string.Empty;
            tbSemStart.Text = string.Empty;
        }

        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;

            int departamentId = 0;
            Departament dep = null;
            if (cbDepartament.Items.Count > 0)
                dep = DepartamentController.Instance.GetDepartament(cbDepartament.SelectedItem.ToString());
            
            if(dep != null)
                departamentId = dep.DepartamentID;

            int facultyId = 0;
            Faculty fac = null;
            if(cbFaculty.Items.Count > 0)
                fac = FacultyController.Instance.GetFaculty(cbFaculty.SelectedItem.ToString());

            if (fac != null)
                facultyId = fac.FacultyID;

            int studiesTypeId = 0;
            StudiesType st = null;
            if (cbStudiesType.Items.Count > 0)
                st = StudiesTypeController.Instance.GetStudiesType(cbStudiesType.SelectedItem.ToString());

            if (st != null)
                studiesTypeId = st.StudiesTypeID;

            int semStart = 0;
            int semEnd = 0;

            int.TryParse(tbSemStart.Text, out semStart);
            int.TryParse(tbSemEnd.Text, out semEnd);

            NewPlan plan = new NewPlan()
            {
                Name = tbPlanName.Text,
              //  YearStart = tbYearStart.Value,
              //  YearEnd = tbYearEnd.Value,
                DepartamentId = departamentId,
                FacultyId = facultyId,
                StudiesTypeId = studiesTypeId,
                SemesterStart = semStart,
                SemesterEnd = semEnd,
                LastEditedUserId = loggedUser.UserID
            };

            if (PlanController.Instance.AddPlan(plan))
            {
                MessageBox.Show("Plan zosta³ dodany", "Info");
                added = true;
                addedPlan = PlanController.Instance.GetPlan(tbPlanName.Text);
                Clear();
            }
            else
            { 
                string msg = string.Empty;
                foreach (string error in plan.Errors)
                    msg = msg + error + "\n";
                lblValidation.Text = msg;
            }

        }

        private void cbDepartament_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            FillWithFaculties();
        }

        private void btnDepartamentsMngmt_Click(object sender, EventArgs e)
        {
            if (new Departaments().ShowDialog() == DialogResult.Yes)
            {
                FillWithDepartaments();
                FillWithFaculties();
            }
        }

        private void btnFacultiesMngmt_Click(object sender, EventArgs e)
        {
            if (new Faculties().ShowDialog() == DialogResult.Yes)
                FillWithFaculties();
        }

        private void btnStudiesTypesMngmt_Click(object sender, EventArgs e)
        {
            if (new StudiesTypes().ShowDialog() == DialogResult.Yes)
                FillWithStudiesTypes();
        }

        private void Plans_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (added)
            {
                this.DialogResult = DialogResult.Yes;
                if (addedPlan != null)
                    MainForm.LoadedPlan = addedPlan;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
