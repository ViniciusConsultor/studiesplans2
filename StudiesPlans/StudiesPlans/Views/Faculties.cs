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
    public partial class Faculties : Telerik.WinControls.UI.RadForm
    {
        private FacultyEdit toEdit = null;
        private bool changes = false;

        public Faculties()
        {
            InitializeComponent();
            FillWithFaculties(null);
            FillWithDepartaments();
            Disable();
            ShowButtonsToolTips();
        }

        private void ShowButtonsToolTips()
        {
            btnAddFaculty.ButtonElement.ToolTipText = "Dodaj kierunek";
            btnCancel.ButtonElement.ToolTipText = "Anuluj edycj�";
            btnDelete.ButtonElement.ToolTipText = "Usu� kierunek";
            btnDepartamentsMngmt.ButtonElement.ToolTipText = "Zarz�dzaj wydzia�ami";
            btnSave.ButtonElement.ToolTipText = "Zapisz zmiany";
        }

        private void Disable()
        {
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnAddFaculty.Enabled = true;
        }

        private void FillWithDepartaments()
        {
            clbDepartaments.Items.Clear();
            cbDepartamentFilter.Items.Clear();
            cbDepartamentFilter.Items.Add("Wszystkie");

            IEnumerable<Departament> departaments = DepartamentController.Instance.ListDepartaments();
            if (departaments != null)
                foreach (Departament d in departaments)
                {
                    clbDepartaments.Items.Add(d.Name);
                    cbDepartamentFilter.Items.Add(d.Name);
                }
            cbDepartamentFilter.SelectedIndex = 0;
        }

        private void FillWithFaculties(Departament dep)
        {
            listFaculties.Items.Clear();
            IEnumerable<Faculty> faculties = null;

            if (dep == null)
                faculties = FacultyController.Instance.ListFaculties();
            else
                faculties = FacultyController.Instance.ListFaculties(dep.DepartamentID);

            if (faculties != null)
                foreach (Faculty f in faculties)
                    listFaculties.Items.Add(f.Name);
        }

        private void btnDepartamentsMngmt_Click(object sender, EventArgs e)
        {
            if (new Departaments().ShowDialog() == DialogResult.Yes)
            {
                FillWithDepartaments();
                Clear();
                toEdit = null;
                Disable();
            }
        }

        private void btnAddFaculty_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            NewFaculty toAdd = new NewFaculty()
            {
                FacultyName = tbNewFacultyName.Text
            };
            List<string> list = clbDepartaments.CheckedItems.Cast<string>().ToList<string>();
            if (list != null && list.Count > 0)
            {
                List<Departament> departaments = new List<Departament>();
                foreach (string name in list)
                {
                    Departament d = DepartamentController.Instance.GetDepartament(name);
                    if (d != null)
                        departaments.Add(d);
                }
                toAdd.Departaments = departaments.AsEnumerable();
            }
            else
                toAdd.Departaments = null;

            if (!FacultyController.Instance.AddFaculty(toAdd))
            {
                string errors = string.Empty;
                foreach (string error in toAdd.Errors)
                    errors = errors + error + "\n";
                lblValidation.Text = errors;
            }
            else
            {
                FillWithFaculties(null);
                cbDepartamentFilter.SelectedIndex = 0;
                Clear();
                changes = true;
            }
        }

        private void Clear()
        {
            tbNewFacultyName.Text = string.Empty;
            clbDepartaments.ClearSelected();
            for (int i = 0; i < clbDepartaments.Items.Count; i++)
                clbDepartaments.SetItemChecked(i, false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (toEdit != null)
            {
                try
                {
                    FacultyController.Instance.DeleteFaculty(toEdit);
                    FillWithFaculties(null);
                    cbDepartamentFilter.SelectedIndex = 0;
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

        private void listFaculties_DoubleClick(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (listFaculties.SelectedIndex >= 0)
            {
                FacultyEdit faculty = FacultyController.Instance.GetFacultyEdit(listFaculties.SelectedItem.ToString());
                if (faculty != null)
                {
                    toEdit = faculty;
                    Enable();
                    tbNewFacultyName.Text = faculty.FacultyName;
                    for (int i = 0; i < clbDepartaments.Items.Count; i++)
                        clbDepartaments.SetItemChecked(i, false);
                    foreach (Departament d in toEdit.Departaments)
                    {
                        for (int i = 0; i < clbDepartaments.Items.Count; i++)
                            if (d.Name.Equals(clbDepartaments.Items[i].ToString()))
                            {
                                clbDepartaments.SetItemChecked(i, true);
                                break;
                            }
                    }
                }
                else
                {
                    lblValidation.Text = "Kierunek nie istnieje";
                    toEdit = null;
                }
            }
        }

        private void Enable()
        {
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnAddFaculty.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (toEdit != null)
            {
                toEdit = null;
                Disable();
                Clear();
                lblValidation.Text = string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (toEdit != null)
            {
                string oldName = toEdit.FacultyName;
                toEdit.FacultyName = tbNewFacultyName.Text;
                if (toEdit.Errors != null)
                    toEdit.ClearErrors();
                List<Departament> list = new List<Departament>();
                for (int i = 0; i < clbDepartaments.CheckedItems.Count; i++)
                {
                    Departament d = DepartamentController.Instance.GetDepartament(clbDepartaments.CheckedItems[i].ToString());
                    if (d != null)
                        list.Add(d);
                }
                if (list.Count > 0)
                    toEdit.Departaments = list.AsEnumerable<Departament>();
                else
                    toEdit.Departaments = null;

                if (!FacultyController.Instance.EditFaculty(toEdit))
                {
                    string errors = string.Empty;
                    foreach (string error in toEdit.Errors)
                        errors = errors + error + "\n";
                    lblValidation.Text = errors;
                    toEdit.FacultyName = oldName;
                }
                else
                {
                    FillWithDepartaments();
                    FillWithFaculties(null);
                    cbDepartamentFilter.SelectedIndex = 0;
                    Clear();
                    Disable();
                    changes = true;
                }
            }
        }

        private void listFaculties_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyValue == 13)
                listFaculties_DoubleClick(sender, e);
        }

        private void Faculties_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
                this.DialogResult = DialogResult.Yes;
        }

        private void cbDepartamentFilter_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Departament dep = DepartamentController.Instance.GetDepartament(cbDepartamentFilter.SelectedItem.ToString());
            FillWithFaculties(dep);
        }
    }
}
