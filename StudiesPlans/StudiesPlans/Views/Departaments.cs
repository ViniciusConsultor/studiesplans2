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
    public partial class Departaments : Telerik.WinControls.UI.RadForm
    {

        private DepartamentEdit toEdit = null;
        private bool changes = false;

        public Departaments()
        {
            InitializeComponent();
            FillWithDepartaments();
            Disable();
        }

        private void Disable()
        {
            btnAddDepartament.Enabled = true;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }

        private void Enable()
        {
            btnAddDepartament.Enabled = false;
            btnCancel.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
        }

        public void Clear()
        {
            txtNewDepartamentName.Text = string.Empty;
        }

        private void FillWithDepartaments()
        {
            listDepartaments.Items.Clear();
            IEnumerable<Departament> departaments = DepartamentController.Instance.ListDepartaments();
            if (departaments != null)
                foreach (Departament d in departaments)
                    listDepartaments.Items.Add(d.Name);
        }

        private void btnAddDepartament_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            NewDepartament toAdd = new NewDepartament()
            {
                DepartamentName = txtNewDepartamentName.Text
            };
            if (!DepartamentController.Instance.AddDepartament(toAdd))
            {
                string errors = string.Empty;
                foreach (string error in toAdd.Errors)
                    errors = errors + error + "\n";
                lblValidation.Text = errors;
            }
            else
            {
                FillWithDepartaments();
                Clear();
                changes = true;
            }
        }

        private void listDepartaments_DoubleClick(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (listDepartaments.SelectedIndex >= 0)
            {
                DepartamentEdit departament = DepartamentController.Instance.GetDepartamentEdit(listDepartaments.SelectedItem.ToString());
                if (departament != null)
                {
                    toEdit = departament;
                    Enable();
                    txtNewDepartamentName.Text = departament.DepartamentName;
                }
                else
                {
                    lblValidation.Text = "Wydzia³ nie istnieje";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (toEdit != null)
            {
                try
                {
                    DepartamentController.Instance.DeleteDepartament(toEdit);
                    FillWithDepartaments();
                    changes = true;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (toEdit != null)
            {
                lblValidation.Text = string.Empty;
                string oldName = toEdit.DepartamentName;
                toEdit.DepartamentName = txtNewDepartamentName.Text;
                if (!DepartamentController.Instance.EditDepartament(toEdit))
                {
                    string errors = string.Empty;
                    foreach (string error in toEdit.Errors)
                        errors = errors + error + "\n";
                    lblValidation.Text = errors;
                    toEdit.DepartamentName = oldName;
                }
                else
                {
                    FillWithDepartaments();
                    Clear();
                    Disable();
                    changes = true;
                }
            }
        }

        private void Departaments_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
                this.DialogResult = DialogResult.Yes;
        }

        private void listDepartaments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
                listDepartaments_DoubleClick(sender, e);
        }
    }
}
