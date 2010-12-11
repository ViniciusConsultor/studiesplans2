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
    public partial class Institutes : Telerik.WinControls.UI.RadForm
    {
        private InstituteEdit toEdit = null;
        bool changes = false;

        public Institutes()
        {
            InitializeComponent();
            FillWithDepartaments();
            FillWithInstitutes(null);
            Disable();
            ShowButtonsToolTips();
        }

        private void ShowButtonsToolTips()
        {
            btnAdd.ButtonElement.ToolTipText = "Dodaj instytut";
            btnCancel.ButtonElement.ToolTipText = "Anuluj edycjê";
            btnDelete.ButtonElement.ToolTipText = "Usuñ instytut";
            btnDepartamentsMnmgt.ButtonElement.ToolTipText = "Zarz¹dzaj wydzia³ami";
            btnSave.ButtonElement.ToolTipText = "Zapisz zmiany";
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

        private void FillWithInstitutes(Departament dep)
        {
            listInstitutes.Items.Clear();
            IEnumerable<Institute> institutes = null;

            if (dep == null)
                institutes = InstituteController.Instance.ListInstitutes();
            else
                institutes = InstituteController.Instance.ListInstitutes(dep.DepartamentID);

            if (institutes != null)
                foreach (Institute f in institutes)
                    listInstitutes.Items.Add(f.Name);
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

        private void Clear()
        {
            tbNewInstituteName.Text = string.Empty;
            clbDepartaments.ClearSelected();
            for (int i = 0; i < clbDepartaments.Items.Count; i++)
                clbDepartaments.SetItemChecked(i, false);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            NewInstitute toAdd = new NewInstitute()
            {
                InstituteName = tbNewInstituteName.Text
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

            if (!InstituteController.Instance.AddInstitute(toAdd))
            {
                string errors = string.Empty;
                foreach (string error in toAdd.Errors)
                    errors = errors + error + "\n";
                lblValidation.Text = errors;
            }
            else
            {
                FillWithInstitutes(null);
                cbDepartamentFilter.SelectedIndex = 0;
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
                    InstituteController.Instance.DeleteInstitute(toEdit);
                    FillWithInstitutes(null);
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

        private void listInstitutes_DoubleClick(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (listInstitutes.SelectedIndex >= 0)
            {
                InstituteEdit institute = InstituteController.Instance.GetInstituteEdit(listInstitutes.SelectedItem.ToString());
                if (institute != null)
                {
                    toEdit = institute;
                    Enable();
                    tbNewInstituteName.Text = institute.InstituteName;
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
                    lblValidation.Text = "Instytut nie istnieje";
                    toEdit = null;
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
                lblValidation.Text = string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (toEdit != null)
            {
                string oldName = toEdit.InstituteName;
                toEdit.InstituteName = tbNewInstituteName.Text;
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

                if (!InstituteController.Instance.EditInstitute(toEdit))
                {
                    string errors = string.Empty;
                    foreach (string error in toEdit.Errors)
                        errors = errors + error + "\n";
                    lblValidation.Text = errors;
                    toEdit.InstituteName = oldName;
                }
                else
                {
                    FillWithDepartaments();
                    FillWithInstitutes(null);
                    cbDepartamentFilter.SelectedIndex = 0;
                    Clear();
                    Disable();
                    changes = true;
                }
            }
        }

        private void Institutes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
                this.DialogResult = DialogResult.Yes;
        }

        private void cbDepartamentFilter_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Departament dep = DepartamentController.Instance.GetDepartament(cbDepartamentFilter.SelectedItem.ToString());
            FillWithInstitutes(dep);
        }
    }
}
