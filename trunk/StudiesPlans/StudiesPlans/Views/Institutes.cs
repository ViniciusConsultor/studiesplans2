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
        public Institutes()
        {
            InitializeComponent();
            FillWithDepartaments();
            FillWithInstitutes();
            Disable();
        }

        private void FillWithDepartaments()
        {
            clbDepartaments.Items.Clear();
            IEnumerable<Departament> departaments = DepartamentController.Instance.ListDepartaments();
            if (departaments != null)
                foreach (Departament d in departaments)
                    clbDepartaments.Items.Add(d.Name);
        }

        private void FillWithInstitutes()
        {
            listInstitutes.Items.Clear();
            IEnumerable<Institute> institutes = InstituteController.Instance.ListInstitutes();
            if (institutes != null)
                foreach (Institute i in institutes)
                    listInstitutes.Items.Add(i.Name);
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
                FillWithInstitutes();
                Clear();
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
                    FillWithInstitutes();
                    toEdit = null;
                    Disable();
                    Clear();
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
                    FillWithInstitutes();
                    Clear();
                    Disable();
                }
            }
        }
    }
}
