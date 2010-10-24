using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using StudiesPlansModels.Models;
using StudiesPlans.Controllers;

namespace StudiesPlans.Views
{
    public partial class EditSubject : Telerik.WinControls.UI.RadForm
    {
        Plan plan = null;
        SubjectEdit subject = null;
        bool changes = false;

        public EditSubject(Plan plan, SubjectEdit subject)
        {
            InitializeComponent();
            lblDepartament.Text = plan.Departament.Name;
            lblFaculty.Text = plan.Faculty.Name;
            FillWithInstitutes();
            FillWithSemesters();
            FillWithSubjectTypes();
            this.plan = plan;
            this.subject = subject;

            tbSubjectName.Text = subject.Name;
            cbInstitute.SelectedItem.Value = subject.Institute;

            Semester sem = SemesterController.Instance.GetSemester(subject.SemesterId);
            cbSemester.SelectedItem.Value = sem == null ? "B³¹d" : sem.Name;

            seEcts.Value = Convert.ToDecimal(subject.Ects);
            ckbxExam.Checked = subject.IsExam;

            foreach (NewSubjectTypeData nst in subject.SubjectTypes)
            {
                SubjectType st = SubjectTypeController.Instance.GetSubjectType(nst.SubjectTypeId);
                for (int i = 0; i < dgSubjectTypes.Rows.Count; i++)
                {
                    if (dgSubjectTypes.Rows[i].Cells["subjectType"].Value.ToString().Equals(st.Name))
                        dgSubjectTypes.Rows[i].Cells["hours"].Value = nst.Hours.ToString();
                }
            }
        }

        private void FillWithSubjectTypes()
        {
            List<SubjectType> subjectTypes = SubjectTypeController.Instance.ListSubjectTypes();
            if (subjectTypes != null)
                foreach (SubjectType st in subjectTypes)
                    dgSubjectTypes.Rows.Add(st.Name, 0);
        }

        private void FillWithSemesters()
        {
            cbSemester.Items.Clear();

            List<Semester> semesters = SemesterController.Instance.ListSemesters();

            if (semesters != null)
            {
                foreach (Semester s in semesters)
                    cbSemester.Items.Add(s.Name);
                cbSemester.SelectedIndex = 0;
            }
        }

        private void FillWithInstitutes()
        {
            cbInstitute.Items.Clear();

            List<Institute> instiutes = InstituteController.Instance.ListInstitutes(lblDepartament.Text);

            if (instiutes != null)
            {
                foreach (Institute i in instiutes)
                    cbInstitute.Items.Add(i.Name);
                cbInstitute.SelectedIndex = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveSubject_Click(object sender, EventArgs e)
        {
            subject.ClearErrors();
            lblValidation.Text = string.Empty;

            this.subject.Ects = Convert.ToDouble(seEcts.Value);
            this.subject.Institute = cbInstitute.SelectedItem.ToString();
            this.subject.IsExam = ckbxExam.Checked;
            this.subject.Name = tbSubjectName.Text;

            Semester sem = SemesterController.Instance.GetSemester(cbSemester.SelectedItem.ToString());
            if (sem != null)
                this.subject.SemesterId = sem.SemesterID;

            List<NewSubjectTypeData> nstdlist = new List<NewSubjectTypeData>();
            for (int i = 0; i < dgSubjectTypes.Rows.Count; i++)
            { 
                if(Convert.ToInt32(dgSubjectTypes.Rows[i].Cells["hours"].Value) > 0)
                {
                    SubjectType st = SubjectTypeController.Instance.GetSubjectType(dgSubjectTypes.Rows[i].Cells["subjectType"].Value.ToString());
                    if (st != null)
                    {
                        NewSubjectTypeData nstd = new NewSubjectTypeData()
                        {
                            Hours = Convert.ToInt32(dgSubjectTypes.Rows[i].Cells["hours"].Value),
                            SubjectTypeId = st.SubjectTypeID
                        };

                        nstdlist.Add(nstd);
                    }
                }
            }

            this.subject.SubjectTypes = nstdlist;

            if (SubjectController.Instance.EditSubject(subject))
            {
                changes = true;
            }
            else
            {
                string errors = string.Empty;
                foreach(string error in subject.Errors)
                    errors = errors + error + "\n";

                lblValidation.Text = errors;
            }
        }

        private void EditSubject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
                this.DialogResult = DialogResult.Yes;
        }
    }
}
