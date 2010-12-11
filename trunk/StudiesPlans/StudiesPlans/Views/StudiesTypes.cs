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

namespace StudiesPlans
{
    public partial class StudiesTypes : Telerik.WinControls.UI.RadForm
    {
        private StudiesTypeEdit toEdit = null;
        private bool changes = false;

        public StudiesTypes()
        {
            InitializeComponent();
            FillWithStudiesTypes();
            Clear();
            Disable();
            ShowButtonsToolTips();
        }

        private void ShowButtonsToolTips()
        {
            btnAdd.ButtonElement.ToolTipText = "Dodaj typ studiów";
            btnCancel.ButtonElement.ToolTipText = "Anuluj edycjê";
            btnDelete.ButtonElement.ToolTipText = "Usuñ typ studiów";
            btnSave.ButtonElement.ToolTipText = "Zapisz zmiany";
        }

        private void FillWithStudiesTypes()
        {
            listStudiesTypes.Items.Clear();
            IEnumerable<StudiesType> studiestypes = StudiesTypeController.Instance.ListStudiesTypes();
            if (studiestypes != null)
            {
                foreach (StudiesType s in studiestypes)
                    listStudiesTypes.Items.Add(s.Name);
            }
        }

        private void Clear()
        {
            lblValidation.Text = string.Empty;
            tbNewStudiesTypeName.Text = string.Empty;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (toEdit != null)
            {
                toEdit = null;
                Disable();
                Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            NewStudiesType toAdd = new NewStudiesType()
            {
                StudiesTypeName = tbNewStudiesTypeName.Text
            };

            if (!StudiesTypeController.Instance.AddStudiesType(toAdd))
            {
                string errors = string.Empty;
                foreach (string error in toAdd.Errors)
                    errors = errors + error + "\n";
                lblValidation.Text = errors;
            }
            else
            {
                FillWithStudiesTypes();
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
                    StudiesTypeController.Instance.DeleteStudiesType(toEdit);
                    FillWithStudiesTypes();
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

        private void listStudiesTypes_DoubleClick(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (listStudiesTypes.SelectedIndex >= 0)
            {
                StudiesTypeEdit studiesType = StudiesTypeController.Instance.GetStudiesTypeEdit(listStudiesTypes.SelectedItem.ToString());
                if (studiesType != null)
                {
                    toEdit = studiesType;
                    Enable();
                    tbNewStudiesTypeName.Text = studiesType.StudiesTypeName;
                }
                else
                {
                    lblValidation.Text = "Typ studiów nie istnieje nie istnieje";
                    toEdit = null;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (toEdit != null)
            {
                string oldName = toEdit.StudiesTypeName;
                toEdit.StudiesTypeName = tbNewStudiesTypeName.Text;
                if (toEdit.Errors != null)
                    toEdit.ClearErrors();

                if (!StudiesTypeController.Instance.EditStudiesType(toEdit))
                {
                    string errors = string.Empty;
                    foreach (string error in toEdit.Errors)
                        errors = errors + error + "\n";
                    lblValidation.Text = errors;
                    toEdit.StudiesTypeName = oldName;
                }
                else
                {
                    FillWithStudiesTypes();
                    Clear();
                    Disable();
                    changes = true;
                }
            }
        }

        private void StudiesTypes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
                this.DialogResult = DialogResult.Yes;
        }
    }
}
