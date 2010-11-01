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
    public partial class SubjectTypes : Form
    {
        private SubjectTypeEdit toEdit = null;
        private bool changes = false;

        public SubjectTypes()
        {
            InitializeComponent();
            FillWithSubjectTypes();
            Clear();
            Disable();
        }

        private void FillWithSubjectTypes()
        {
            listSubjectTypes.Items.Clear();
            IEnumerable<SubjectType> subjectTypes = SubjectTypeController.Instance.ListSubjectTypes();
            if (subjectTypes != null)
            {
                foreach (SubjectType st in subjectTypes)
                    listSubjectTypes.Items.Add(st.Name);
            }
        }

        private void Clear()
        {
            lblValidation.Text = string.Empty;
            tbNewSubjectTypeName.Text = string.Empty;
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
            NewSubjectType toAdd = new NewSubjectType()
            {
                SubjectTypeName = tbNewSubjectTypeName.Text
            };

            if (!SubjectTypeController.Instance.AddSubjectType(toAdd))
            {
                string errors = string.Empty;
                foreach (string error in toAdd.Errors)
                    errors = errors + error + "\n";
                lblValidation.Text = errors;
            }
            else
            {
                FillWithSubjectTypes();
                Clear();
                changes = true;
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

        private void listSubjectTypes_DoubleClick(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (listSubjectTypes.SelectedIndex >= 0)
            {
                SubjectTypeEdit subjectType = SubjectTypeController.Instance.GetSubjectTypeEdit(listSubjectTypes.SelectedItem.ToString());
                if (subjectType != null)
                {
                    toEdit = subjectType;
                    Enable();
                    tbNewSubjectTypeName.Text = subjectType.SubjectTypeName;
                }
                else
                {
                    lblValidation.Text = "Typ przedmiotu nie istnieje";
                    toEdit = null;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (toEdit != null)
            {
                try
                {
                    SubjectTypeController.Instance.DeleteSubjectType(toEdit);
                    FillWithSubjectTypes();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (toEdit != null)
            {
                string oldName = toEdit.SubjectTypeName;
                toEdit.SubjectTypeName = tbNewSubjectTypeName.Text;
                if (toEdit.Errors != null)
                    toEdit.ClearErrors();

                if (!SubjectTypeController.Instance.EditSubjectType(toEdit))
                {
                    string errors = string.Empty;
                    foreach (string error in toEdit.Errors)
                        errors = errors + error + "\n";
                    lblValidation.Text = errors;
                    toEdit.SubjectTypeName = oldName;
                }
                else
                {
                    FillWithSubjectTypes();
                    Clear();
                    Disable();
                    changes = true;
                }
            }
        }

        private void SubjectTypes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
