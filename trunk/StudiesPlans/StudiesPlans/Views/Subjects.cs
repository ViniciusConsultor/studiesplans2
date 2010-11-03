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
using System.Linq;
using Telerik.WinControls.UI;

namespace StudiesPlans.Views
{
    public partial class Subjects : Telerik.WinControls.UI.RadForm
    {
        Plan plan = null;
        public Subjects(Plan plan)
        {
            InitializeComponent();
            lblDepartament.Text = plan.Departament.Name;
            lblFaculty.Text = plan.Faculty.Name;
            this.plan = plan;
            FillWithInstitutes();
            FillWithSemesters();
            FillWithSubjectTypes();
            FillWithSpecializations();
        }

        private void FillWithSubjectTypes()
        {
            dgSubjectTypes.Rows.Clear();
            List<SubjectType> subjectTypes = SubjectTypeController.Instance.ListSubjectTypes();
            if (subjectTypes != null)
                foreach(SubjectType st in subjectTypes)
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

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            Institute institute = null;
            if (!cbInstitute.SelectedItem.ToString().Equals("Brak"))
                institute = InstituteController.Instance.GetInstitute(cbInstitute.SelectedItem.ToString(), plan.DepartamentID);

            if (institute == null && !cbInstitute.SelectedItem.ToString().Equals("Brak"))
            {
                MessageBox.Show("Wybrany instytut ju¿ nie istnieje");
                FillWithInstitutes();
                return;
            }

            Semester semester = SemesterController.Instance.GetSemester(cbSemester.SelectedItem.ToString());
            
            if(semester == null)
            {
                MessageBox.Show("Wybrany semestr ju¿ nie istnieje");
                FillWithSemesters();
                return;
            }

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

            List<NewSpecializationData> nspdlist = new List<NewSpecializationData>();
            if (dgSpecializations.Enabled == true)
                for (int i = 0; i < dgSpecializations.Rows.Count; i++)
                { 
                    SpecializationEdit s = SpecializationController.Instance.GetSpecializationEdit(dgSpecializations.Rows[i].Cells["specialization"].Value.ToString());
                    if (s!=null)
                    {
                        NewSpecializationData nspd = new NewSpecializationData()
                        {
                            IsElective = Convert.ToBoolean(dgSpecializations.Rows[i].Cells["elective"].Value),
                            IsGenereal = Convert.ToBoolean(dgSpecializations.Rows[i].Cells["general"].Value),
                            SpecializationId = s.SpecializationID
                        };

                        nspdlist.Add(nspd);
                    }
                }

            NewSubject subject = new NewSubject()
            {
                DepartamentId = plan.DepartamentID,
                Ects = Convert.ToDouble(seEcts.Value),
                FacultyId = plan.FacultyID,
                InstituteId = institute == null ? 0 : institute.InstituteID,
                IsExam = ckbxExam.Checked, 
                Name = tbSubjectName.Text,
                SemesterId = semester.SemesterID,
                SubjectTypes = nstdlist,
                PlanId = plan.PlanID,
                Specializations = nspdlist.Count > 0 ? nspdlist : null,
                IsElective = cbElective.Checked,
                IsGeneral = cbGeneral.Checked
            };

            if (SubjectController.Instance.AddSubject(subject))
            {
                MessageBox.Show("Added");

                //NewPlanData npd = new NewPlanData()
                //{
                //    PlanId = plan.PlanID,
                //    SubjectId = subjectId
                //};

                //if (PlanController.Instance.AddPlanData(npd))
                //{ }
            }
            else
            {
                string errors = string.Empty;
                foreach (string error in subject.Errors)
                    errors = errors + error + "\n";

                lblValidation.Text = errors;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSemestersMnmgt_Click(object sender, EventArgs e)
        {
            if (new Semesters().ShowDialog() == DialogResult.Yes)
                FillWithSemesters();
        }

        private void btnInstitutesMngmt_Click(object sender, EventArgs e)
        {
            if (new Institutes().ShowDialog() == DialogResult.Yes)
                FillWithInstitutes();
        }

        private void btnSpecMngmt_Click(object sender, EventArgs e)
        {
            if (new Specializations().ShowDialog() == DialogResult.Yes)
                FillWithSpecializations();
        }

        private void btnSubjectTypesMnmgt_Click(object sender, EventArgs e)
        {
            if (new SubjectTypes().ShowDialog() == DialogResult.Yes)
                FillWithSubjectTypes();
        }

        private void btnClearSpec_Click(object sender, EventArgs e)
        {
            dgSpecializations.Rows.Clear();
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

    }
}
