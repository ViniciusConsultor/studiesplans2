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
    public partial class Subjects : Telerik.WinControls.UI.RadForm
    {
        Plan plan = null;
        public Subjects(Plan plan)
        {
            InitializeComponent();
            lblDepartament.Text = plan.Departament.Name;
            lblFaculty.Text = plan.Faculty.Name;
            FillWithInstitutes();
            FillWithSemesters();
            FillWithSubjectTypes();
            this.plan = plan;
        }

        private void FillWithSubjectTypes()
        {
            List<SubjectType> subjectTypes = SubjectTypeController.Instance.ListSubjectTypes();
            if (subjectTypes != null)
                foreach(SubjectType st in subjectTypes)
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

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            Institute institute = InstituteController.Instance.GetInstitute(cbInstitute.SelectedItem.ToString(), plan.DepartamentID);

            if(institute == null)
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

            NewSubject subject = new NewSubject()
            {
                DepartamentId = plan.DepartamentID,
                Ects = Convert.ToDouble(seEcts.Value),
                FacultyId = plan.FacultyID,
                InstituteId = institute.InstituteID,
                IsExam = ckbxExam.Checked, 
                Name = tbSubjectName.Text,
                SemesterId = semester.SemesterID,
                SubjectTypes = nstdlist
            };

            if (SubjectController.Instance.AddSubject(subject))
            {
                MessageBox.Show("Added");
            }
            else
            { }
        }

    }
}
