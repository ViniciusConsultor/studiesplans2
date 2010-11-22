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
    public partial class Semesters : Telerik.WinControls.UI.RadForm
    {
        private SemesterEdit toEdit = null;
        bool changes = false;

        public Semesters()
        {
            InitializeComponent();
            FillWithSemesters();
            Clear();
            Disable();
        }

        private void FillWithSemesters()
        {
            dgSemesters.Rows.Clear();
            IEnumerable<Semester> semesters = SemesterController.Instance.ListSemesters();
            if (semesters != null)
            {
                foreach (Semester s in semesters)
                    dgSemesters.Rows.Add(s.Name, s.Semester1, s.StudyYear);
            }
        }

        private void Clear()
        {
            lblValidation.Text = string.Empty;
            tbNewSemesterName.Text = string.Empty;
            tbNewSemesterYear.Text = string.Empty;
            tbNewSemestrNo.Text = string.Empty;
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
            int no = 0;
            int year = 0;

            int.TryParse(tbNewSemestrNo.Text, out no);
            int.TryParse(tbNewSemesterYear.Text, out year);

            NewSemester toAdd = new NewSemester()
            {
                SemesterName = tbNewSemesterName.Text,
                SemesterNo = no,
                SemesterYear = year
            };

            if (!SemesterController.Instance.AddSemester(toAdd))
            {
                string errors = string.Empty;
                foreach (string error in toAdd.Errors)
                    errors = errors + error + "\n";
                lblValidation.Text = errors;
            }
            else
            {
                FillWithSemesters();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (toEdit != null)
            {
                try
                {
                    SemesterController.Instance.DeleteSemester(toEdit);
                    FillWithSemesters();
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
                string oldName = toEdit.SemesterName;
                int oldNo = toEdit.SemesterNo;
                int oldYear = toEdit.SemesterYear;

                int newYear = 0;
                int newNo = 0;

                int.TryParse(tbNewSemesterYear.Text, out newYear);
                int.TryParse(tbNewSemestrNo.Text, out newNo);

                toEdit.SemesterName = tbNewSemesterName.Text;
                toEdit.SemesterNo = newNo;
                toEdit.SemesterYear = newYear;

                if (toEdit.Errors != null)
                    toEdit.ClearErrors();

                if (!SemesterController.Instance.EditSemester(toEdit))
                {
                    string errors = string.Empty;
                    foreach (string error in toEdit.Errors)
                        errors = errors + error + "\n";
                    lblValidation.Text = errors;
                    toEdit.SemesterName = oldName;
                    toEdit.SemesterNo = oldNo;
                    toEdit.SemesterYear = oldYear;
                }
                else
                {
                    FillWithSemesters();
                    Clear();
                    Disable();
                    changes = true;
                }
            }
        }

        private void dgSemesters_DoubleClick(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (e.Row.Index >= 0)
            {
                int no = 0;
                int year = 0;

                int.TryParse(dgSemesters.Rows[e.Row.Index].Cells["cNo"].Value.ToString(), out no);
                int.TryParse(dgSemesters.Rows[e.Row.Index].Cells["cYear"].Value.ToString(), out year);

                SemesterEdit semester = SemesterController.Instance.GetSemesterEdit(
                    dgSemesters.Rows[e.Row.Index].Cells["cName"].Value.ToString(),
                    no, year);

                if (semester != null)
                {
                    toEdit = semester;
                    Enable();
                    tbNewSemesterName.Text = semester.SemesterName;
                    tbNewSemestrNo.Text = semester.SemesterNo.ToString();
                    tbNewSemesterYear.Text = semester.SemesterYear.ToString();
                }
                else
                {
                    lblValidation.Text = "Semestr nie istnieje";
                    toEdit = null;
                }
            }
        }

        private void Semesters_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
                this.DialogResult = DialogResult.Yes;
        }

        private void dgSemesters_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            lblValidation.Text = string.Empty;
            if (e.Row.Index >= 0)
            {
                int no = 0;
                int year = 0;

                int.TryParse(dgSemesters.Rows[e.Row.Index].Cells["cNo"].Value.ToString(), out no);
                int.TryParse(dgSemesters.Rows[e.Row.Index].Cells["cYear"].Value.ToString(), out year);

                SemesterEdit semester = SemesterController.Instance.GetSemesterEdit(
                    dgSemesters.Rows[e.Row.Index].Cells["cName"].Value.ToString(),
                    no, year);

                if (semester != null)
                {
                    toEdit = semester;
                    Enable();
                    tbNewSemesterName.Text = semester.SemesterName;
                    tbNewSemestrNo.Text = semester.SemesterNo.ToString();
                    tbNewSemesterYear.Text = semester.SemesterYear.ToString();
                }
                else
                {
                    lblValidation.Text = "Semestr nie istnieje";
                    toEdit = null;
                }
            }
        }
    }
}
