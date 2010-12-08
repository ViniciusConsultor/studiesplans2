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
using Telerik.WinControls.UI;
using System.Linq;

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
            this.plan = plan;
            this.subject = subject;
            lblDepartament.Text = plan.Departament.Name;
            lblFaculty.Text = plan.Faculty.Name;
            FillWithInstitutes();
            FillWithSemesters();
            FillWithSubjectTypes();
            FillWithSpecializations();

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

            if (subject.Specializations != null)
            {
                foreach (SpecializationDataEdit sde in subject.Specializations)
                {
                    Specialization s = SpecializationController.Instance.GetSpecialization(sde.SpecializationId);
                    dgSpecializations.Rows.Add(s.Name, sde.IsGenereal, sde.IsElective);
                }
            }
            else
                dgSpecializations.Enabled = false;

            cbElective.Checked = subject.IsElective;
            cbGeneral.Checked = subject.IsGeneral;
        }

        private void FillWithSubjectTypes()
        {
            List<SubjectType> subjectTypes = SubjectTypeController.Instance.ListSubjectTypes();
            if (subjectTypes != null)
                foreach (SubjectType st in subjectTypes)
                    dgSubjectTypes.Rows.Add(st.Name, 0);
        }

        private void FillWithSpecializations()
        {
            List<Specialization> list = SpecializationController.Instance.ListSpecializations(plan.DepartamentID, plan.FacultyID).ToList<Specialization>();
            List<string> names = new List<string>();
            foreach (Specialization item in list)
                names.Add(item.Name);
            GridViewComboBoxColumn chkCol = dgSpecializations.Columns["specialization"] as GridViewComboBoxColumn;
            if (chkCol != null)
            {
                chkCol.DataSource = names;
                chkCol.AutoSizeMode = BestFitColumnMode.DisplayedDataCells;
            }
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
            cbInstitute.Items.Add("Brak");

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
            this.subject.IsElective = cbElective.Checked;
            this.subject.IsGeneral = cbGeneral.Checked;

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

            if (subject.Specializations != null && subject.Specializations.Count() > 0)
            { 
                if(dgSpecializations.Rows.Count > 0 && dgSpecializations.Enabled)
                {
                    Specialization spec = SpecializationController.Instance.GetSpecialization(dgSpecializations.Rows[0].Cells["specialization"].Value.ToString());

                    if(spec != null)
                    {
                        subject.Specializations.ElementAt(0).SpecializationId = spec.SpecializationID;
                        subject.Specializations.ElementAt(0).IsElective = Convert.ToBoolean(dgSpecializations.Rows[0].Cells["elective"].Value);
                        subject.Specializations.ElementAt(0).IsGenereal = Convert.ToBoolean(dgSpecializations.Rows[0].Cells["general"].Value);
                    }
                }
            }

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

        private void btnClearSpec_Click(object sender, EventArgs e)
        {
            dgSpecializations.Rows.Clear();
        }

        private void btnSpecMngmt_Click(object sender, EventArgs e)
        {
            if (new Specializations().ShowDialog() == DialogResult.Yes)
                FillWithSpecializations();
        }

        private void cbGeneral_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (cbGeneral.Checked)
            {
                dgSpecializations.Enabled = false;
                cbElective.Enabled = false;
            }
            else
            {
                dgSpecializations.Enabled = true;
                cbElective.Enabled = true;
            }
        }

        private void cbElective_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (cbElective.Checked)
            {
                cbGeneral.Enabled = false;
                dgSpecializations.Columns["elective"].ReadOnly = true;

                for (int i = 0; i < dgSpecializations.Rows.Count; i++)
                    dgSpecializations.Rows[i].Cells["elective"].Value = false;
            }
            else
            {
                dgSpecializations.Columns["elective"].ReadOnly = false;
                cbGeneral.Enabled = true;
            }
        }
    }
}
