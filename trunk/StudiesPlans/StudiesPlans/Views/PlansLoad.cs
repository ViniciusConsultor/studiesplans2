using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using StudiesPlans.Controllers;
using StudiesPlansModels.Models;
using System.Linq;
using StudiesPlansModels.Helpers;

namespace StudiesPlans.Views
{
    public partial class PlansLoad : Telerik.WinControls.UI.RadForm
    {
        public bool IsArchive { get; set; }

        public PlansLoad(bool archive)
        {
            InitializeComponent();
            IsArchive = archive;

            if (!this.IsArchive)
                FillWithPlans(null);
            else
                FillWithArchive(null);

            FillWithDepartaments();
            FillWithFaculties();
            FillWithYears();

            if (this.IsArchive)
            {
                rbAll.Enabled = false;
                rbMandatory.Enabled = false;
                rbArchived.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            }
            else
            {
                DisableAll();
                rbAll.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
                rbArchived.Enabled = false;
            }
        }

        private void DisableAll()
        {
            ckxSemEnd.Enabled = false;
            ckxSemStart.Enabled = false;
            ckxYearEnd.Enabled = false;
            ckxYearStart.Enabled = false;

            cbYearEnd.Enabled = false;
            cbYearStart.Enabled = false;

            tbSemEnd.Enabled = false;
            tbSemStart.Enabled = false;
        }

        private void FillWithYears()
        {
            int year = DateTime.UtcNow.Year;
            for (int i = 1940; i <= year; i++)
            { 
                cbYearEnd.Items.Add(i.ToString());
                cbYearStart.Items.Add(i.ToString());
            }
            cbYearStart.SelectedIndex = cbYearEnd.SelectedIndex = 0;
        }

        private void FillWithFaculties()
        {
            cbFaculty.Items.Clear();
            cbFaculty.Items.Add("Wszystkie");

            if(!cbDepartament.SelectedItem.ToString().Equals("Wszystkie"))
            {
                Departament dep = DepartamentController.Instance.GetDepartament(cbDepartament.SelectedItem.ToString());
                
                if (dep != null)
                {
                    List<Faculty> faculties = FacultyController.Instance.ListFaculties(dep.DepartamentID);
                    
                    if (faculties != null)
                    {
                        foreach (Faculty f in faculties)
                            cbFaculty.Items.Add(f.Name);
                    }
                }
            }

            cbFaculty.SelectedIndex = 0;
        }

        private void FillWithArchive(PlanFilter filter)
        {
            lstPlan.Items.Clear();

            if (filter == null)
            {
                List<Plan> plans = PlanController.Instance.ListArchivedPlans();
                if (plans != null)
                    foreach (Plan p in plans)
                        lstPlan.Items.Add(p.Name);
            }
        }

        private void FillWithPlans(PlanFilter filter)
        {
            lstPlan.Items.Clear();

            List<Plan> plans = null;

            if (filter == null)
                plans = PlanController.Instance.ListPlans();
            else
                plans = PlanController.Instance.ListPlans(filter);

            if (plans != null)
                foreach (Plan p in plans)
                    lstPlan.Items.Add(p.Name);
        }

        private void FillWithDepartaments()
        {
            List<Departament> departaments = DepartamentController.Instance.ListDepartaments().ToList();
            cbDepartament.Items.Add("Wszystkie");

            if (departaments != null)
            {
                foreach (Departament d in departaments)
                    cbDepartament.Items.Add(d.Name);

                cbDepartament.SelectedIndex = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (lstPlan.Items.Count > 0)
            {
                Plan toLoad = PlanController.Instance.GetPlan(lstPlan.SelectedItem.ToString());

                if (toLoad != null)
                {
                    if (!this.IsArchive)
                        StudiesPlans.Views.MainForm.LoadedPlan = toLoad;
                    else
                        StudiesPlans.Views.MainForm.ArchivedPlan = toLoad;

                    this.Close();
                }
                else
                    MessageBox.Show("Wybrany plan nie istnieje");
            }
        }

        private void cbDepartament_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            FillWithFaculties();
        }

        private void rbAll_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rbAll.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                DisableAll();
        }

        private void rbMandatory_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rbMandatory.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                EnableMandatory();
        }

        private void EnableMandatory()
        {
            ckxSemEnd.Enabled = true;
            ckxSemStart.Enabled = true;
            ckxYearEnd.Enabled = false;
            ckxYearStart.Enabled = true;

            cbYearEnd.Enabled = false;
            cbYearStart.Enabled = true;

            tbSemEnd.Enabled = true;
            tbSemStart.Enabled = true;
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            if (!this.IsArchive)
                FillWithPlans(null);
            else
                FillWithArchive(null);
        }

        private void btnSetFilter_Click(object sender, EventArgs e)
        {
            PlanFilter filter = new PlanFilter();

            if (tbPlanName.Text == null || tbPlanName.Text.Equals(string.Empty))
                filter.Name = null;
            else
                filter.Name = tbPlanName.Text;

            if (!cbDepartament.SelectedItem.ToString().Equals("Wszystkie"))
            {
                filter.DepartamentName = cbDepartament.SelectedItem.ToString();

                if (!cbFaculty.SelectedItem.ToString().Equals("Wszystkie"))
                    filter.FacultyName = cbFaculty.SelectedItem.ToString();
            }
            else
                filter.FacultyName = filter.DepartamentName = null;

            filter.All = rbAll.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On ? true : false;
            filter.IsArchieved = rbArchived.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On ? true : false;
            filter.IsMandatory = rbMandatory.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On ? true : false;

            filter.YearStart = ckxYearStart.Enabled == true && ckxYearStart.Checked ? Convert.ToInt32(cbYearStart.SelectedItem.ToString()) : 0;
            filter.YearEnd = ckxYearEnd.Enabled == true && ckxYearEnd.Checked ? Convert.ToInt32(cbYearEnd.SelectedItem.ToString()) : 0;

            int semester = 0;

            if (ckxSemStart.Enabled == true && ckxSemStart.Checked)
            {
                int.TryParse(tbSemStart.Text, out semester);
                filter.SemesterStart = semester;
            }

            if (ckxSemEnd.Enabled == true && ckxSemEnd.Checked)
            {
                int.TryParse(tbSemEnd.Text, out semester);
                filter.SemesterEnd = semester;
            }

            if (this.IsArchive)
                FillWithArchive(filter);
            else
                FillWithPlans(filter);
        }
    }
}
