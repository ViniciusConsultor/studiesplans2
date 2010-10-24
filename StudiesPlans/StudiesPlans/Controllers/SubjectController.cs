using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;

namespace StudiesPlans.Controllers
{
    public class SubjectController
    {
        private static SubjectController instance;
        private ISubjectsRepository repository;

        public static SubjectController Instance
        {
            get
            {
                if (instance == null)
                    instance = new SubjectController(new SubjectsRepository());

                return instance;
            }
        }

        public SubjectController(ISubjectsRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<SubjectsData> ListSubjects()
        {
            return this.repository.ListSubjects();
        }

        public bool AddSubject(NewSubject ns)
        {
            SubjectsData sd = this.repository.GetSubjectData(ns.Name, ns.DepartamentId, ns.Ects, ns.FacultyId, ns.InstituteId, ns.IsExam, ns.PlanId, ns.SemesterId);
            if (sd != null)
                ns.AddError("Przedmiot o podanych danych już istnieje w planie");

            if (ns != null && ns.IsValid)
            {
                this.repository.AddSubject(ns);
                return true;
            }
            return false;
        }

        public SubjectsData GetSubject(int subjectDataId)
        {
            return this.repository.GetSubjectData(subjectDataId);
        }

        public SubjectsData GetSubject(SubjectEdit subject)
        {
            Departament dep = DepartamentController.Instance.GetDepartament(subject.Departament);
            int departamentId = dep == null ? 0 : dep.DepartamentID;

            Faculty fac = FacultyController.Instance.GetFaculty(subject.Faculty);
            int facultyId = fac == null ? 0 : fac.FacultyID;

            Institute inst = InstituteController.Instance.GetInstitute(subject.Institute, departamentId);
            int instituteId = inst == null ? 0 : inst.InstituteID;

            return this.repository.GetSubjectData(subject.Name, departamentId, subject.Ects, 
                facultyId, instituteId, subject.IsExam, subject.PlanId, subject.SemesterId);
        }

        public bool DeleteSubject(SubjectEdit se)
        {
            if (se != null)
            {
                SubjectsData sd = GetSubject(se);
                if (sd != null)
                {
                    this.repository.DeleteSubject(sd);
                    return true;
                }
            }
            return false;
        }

        public bool EditSubject(SubjectEdit subject)
        {
            if (subject != null)
            {
                SubjectsData st = GetSubject(subject);
                if (st != null && st.SubjectDataID != subject.SubjectId && st.Subject.Name.ToLower().Equals(subject.Name.ToLower())
                    && subject.SemesterId == st.SemesterID)
                    subject.AddError("Przedmiot o takich danych już istnieje");

                if (subject.IsValid)
                {
                    st = this.repository.GetSubjectData(subject.SubjectId);

                    Subject s = this.repository.GetSubject(subject.Name);
                    if (s == null)
                    {
                        Subject newSubject = new Subject()
                        {
                            Name = subject.Name
                        };
                        this.repository.AddSubjectName(newSubject);
                    }

                    s = this.repository.GetSubject(subject.Name);

                    st.Subject = s;

                    Departament dep = DepartamentController.Instance.GetDepartament(subject.Departament);
                    int departamentId = dep == null ? 0 : dep.DepartamentID;

                    Institute inst = InstituteController.Instance.GetInstitute(subject.Institute, departamentId);
                    st.InstituteID = inst == null ? 0 : inst.InstituteID;

                    st.Ects = subject.Ects;
                    st.IsExam = subject.IsExam;
                    st.SemesterID = subject.SemesterId;
                    st.SubjectTypesDatas.Clear();
                    foreach (NewSubjectTypeData d in subject.SubjectTypes)
                    {
                        SubjectTypesData std = new SubjectTypesData()
                        {
                            Hours = d.Hours,
                            SubjectTypeID = d.SubjectTypeId
                        };

                        st.SubjectTypesDatas.Add(std);
                    }

                    this.repository.EditSubject(st);
                    return true;
                }
            }
            return false;
        }
    }
}
