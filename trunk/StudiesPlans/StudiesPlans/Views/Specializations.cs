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
using StudiesPlans.Controllers;

namespace StudiesPlans.Views
{
    public partial class Specializations : Telerik.WinControls.UI.RadForm
    {
        private SpecializationEdit toEdit = null;
        bool changes = false;

        public Specializations()
        {
            InitializeComponent();
            FillWithSpecializations();
            FillWithDepartaments();
            FillWithFaculties();
            Clear();
            Disable();
            ShowButtonsToolTips();
        }

        private void ShowButtonsToolTips()
        {
            btnAdd.ButtonElement.ToolTipText = "Dodaj specjalizacjê";
            btnCancel.ButtonElement.ToolTipText = "Anuluj edycjê";
            btnDelete.ButtonElement.ToolTipText = "Usuñ specjalizacjê";
            btnDepartamentsMngmt.ButtonElement.ToolTipText = "Zarz¹dzaj wydzia³ami";
            btnFacultiesManagement.ButtonElement.ToolTipText = "Zarz¹dzaj kierunkami";
            btnSave.ButtonElement.ToolTipText = "Zapisz zmiany";
        }

        private void FillWithFaculties()
        {
            lstFaculties.Items.Clear();
            if (lstDepartaments.SelectedIndex >= 0)
            {
                Departament dep = DepartamentController.Instance.GetDepartament(lstDepartaments.SelectedItem.ToString());
                if (dep != null)
                {
                    IEnumerable<Faculty> faculties = FacultyController.Instance.ListFaculties(dep.DepartamentID);
                    if (faculties != null)
                    {
                        foreach (Faculty f in faculties)
                            lstFaculties.Items.Add(f.Name);
                        lstFaculties.SelectedIndex = 0;
                    }
                }
            }
        }

        private void FillWithDepartaments()
        {
            lstDepartaments.Items.Clear();
            IEnumerable<Departament> departaments = DepartamentController.Instance.ListDepartaments();
            if (departaments != null)
            {
                foreach (Departament d in departaments)
                    lstDepartaments.Items.Add(d.Name);
                lstDepartaments.SelectedIndex = 0;
            }
        }

        private void FillWithSpecializations()
        {
            gridSpecializations.Rows.Clear();
            IEnumerable<Specialization> specializations = SpecializationController.Instance.ListSpecializations();
            if (specializations != null)
            {
                foreach (Specialization s in specializations)
                    gridSpecializations.Rows.Add(s.Name, s.Departament.Name, s.Faculty.Name);
            }
        }

        private void Clear()
        {
            lblValidation.Text = string.Empty;
            tbNewSpecializationName.Text = string.Empty;
        }

        private void Disable()
        {
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void Enable()
        {
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;

            Departament dep = null;
            if (lstDepartaments.Items.Count > 0)
                dep = DepartamentController.Instance.GetDepartament(lstDepartaments.SelectedItem.ToString());

            Faculty fac = null;
            if (lstFaculties.Items.Count > 0)
                fac = FacultyController.Instance.GetFaculty(lstFaculties.SelectedItem.ToString());

            NewSpecialization toAdd = new NewSpecialization()
            {
                SpecializationName = tbNewSpecializationName.Text,
                DepartamentId = dep == null? 0 : dep.DepartamentID,
                FacultyId = fac == null? 0 : fac.FacultyID
            };

            if (!SpecializationController.Instance.AddSpecialization(toAdd))
            {
                string errors = string.Empty;
                foreach (string error in toAdd.Errors)
                    errors = errors + error + "\n";
                lblValidation.Text = errors;
            }
            else
            {
                FillWithSpecializations();
                Clear();
                changes = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (toEdit != null)
            {
                try
                {
                    SpecializationController.Instance.DeleteSpecialization(toEdit);
                    FillWithSpecializations();
                    toEdit = null;
                    Disable();
                    Clear();
                    changes = true;
                }
                catch (UpdateException ex)
                {
                    lblValidation.Text = ex.Message;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (toEdit != null)
            {
                toEdit = null;
                Disable();
                Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (toEdit != null)
            {
                toEdit.ClearErrors();
                string oldName = toEdit.SpecializationName;
                toEdit.SpecializationName = tbNewSpecializationName.Text;

                Departament dep = null;
                if (lstDepartaments.Items.Count > 0)
                    dep = DepartamentController.Instance.GetDepartament(lstDepartaments.SelectedItem.ToString());
                
                Faculty fac = null;
                if (lstFaculties.Items.Count > 0)
                    fac = FacultyController.Instance.GetFaculty(lstFaculties.SelectedItem.ToString());
                
                toEdit.DepartamentId = dep == null ? 0 : dep.DepartamentID;
                toEdit.FacultyId = fac == null ? 0 : fac.FacultyID;

                if (toEdit.Errors != null)
                    toEdit.ClearErrors();

                if (!SpecializationController.Instance.EditSpecialization(toEdit))
                {
                    string errors = string.Empty;
                    foreach (string error in toEdit.Errors)
                        errors = errors + error + "\n";
                    lblValidation.Text = errors;
                    toEdit.SpecializationName = oldName;
                }
                else
                {
                    FillWithSpecializations();
                    Clear();
                    Disable();
                    changes = true;
                }
            }
        }

        private void lstDepartaments_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
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

        private void btnFacultiesManagement_Click(object sender, EventArgs e)
        {
            if (new Faculties().ShowDialog() == DialogResult.Yes)
                FillWithFaculties();
        }

        private void Specializations_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
                this.DialogResult = DialogResult.Yes;
        }

        private void gridSpecializations_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SpecializationEdit specialization = SpecializationController.Instance.GetSpecializationEdit(gridSpecializations.Rows[e.RowIndex].Cells["name"].Value.ToString(),
                                                    gridSpecializations.Rows[e.RowIndex].Cells["departament"].Value.ToString(), gridSpecializations.Rows[e.RowIndex].Cells["faculty"].Value.ToString());
                if (specialization != null)
                {
                    toEdit = specialization;
                    Enable();
                    tbNewSpecializationName.Text = specialization.SpecializationName;

                    Departament dep = DepartamentController.Instance.GetDepartament(specialization.DepartamentId);
                    Faculty fac = FacultyController.Instance.GetFaculty(specialization.FacultyId);

                    if (dep != null)
                        for (int i = 0; i < lstDepartaments.Items.Count; i++)
                            if (lstDepartaments.Items[i].Text.Equals(dep.Name))
                                lstDepartaments.SelectedIndex = i;
                    //lstDepartaments.SelectedItem.Value = dep.Name;

                    if (fac != null && dep != null)
                        for (int i = 0; i < lstFaculties.Items.Count; i++)
                            if (lstFaculties.Items[i].Text.Equals(fac.Name))
                                lstFaculties.SelectedIndex = i;
                    //lstFaculties.SelectedItem.Value = fac.Name;
                }
                else
                {
                    lblValidation.Text = "Specjalizacja nie istnieje";
                    toEdit = null;
                }
            }
        }
    }
}
