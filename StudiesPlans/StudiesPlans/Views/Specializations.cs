using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudiesPlansModels.Models;
using StudiesPlans.Controllers;

namespace StudiesPlans.Views
{
    public partial class Specializations : Form
    {
        private SpecializationEdit toEdit = null;
        public Specializations()
        {
            InitializeComponent();
            FillWithSpecializations();
            Clear();
            Disable();
        }

        private void FillWithSpecializations()
        {
            listSpecializations.Items.Clear();
            IEnumerable<Specialization> specializations = SpecializationController.Instance.ListSpecializations();
            if (specializations != null)
            {
                foreach (Specialization s in specializations)
                    listSpecializations.Items.Add(s.Name);
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
            NewSpecialization toAdd = new NewSpecialization()
            {
                SpecializationName = tbNewSpecializationName.Text
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
                }
                catch (UpdateException ex)
                {
                    lblValidation.Text = ex.Message;
                }
            }
        }

        private void listSpecializations_DoubleClick(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (listSpecializations.SelectedIndex >= 0)
            {
                SpecializationEdit specialization = SpecializationController.Instance.GetSpecializationEdit(listSpecializations.SelectedItem.ToString());
                if (specialization != null)
                {
                    toEdit = specialization;
                    Enable();
                    tbNewSpecializationName.Text = specialization.SpecializationName;
                }
                else
                {
                    lblValidation.Text = "Specjalizacja nie istnieje";
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
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (toEdit != null)
            {
                string oldName = toEdit.SpecializationName;
                toEdit.SpecializationName = tbNewSpecializationName.Text;
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
                }
            }
        }
    }
}
