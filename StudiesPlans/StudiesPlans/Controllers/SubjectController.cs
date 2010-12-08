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
            SubjectsData sd = this.repository.GetSubjectDataForAdding(ns.Name, ns.DepartamentId, ns.Ects, ns.FacultyId, ns.InstituteId, ns.IsExam, ns.PlanId, ns.SemesterId, ns.Specializations);
            if (sd != null)
                ns.AddError("Przedmiot o podanych danych już\nistnieje w planie");

            if (ns.IsElective && ns.IsGeneral)
                ns.AddError("Przedmiot nie może być\njednocześnie obowiązkowy i obieralny");

            if (!ns.IsElective && !ns.IsGeneral && (ns.Specializations == null || ns.Specializations.Count() == 0))
                ns.AddError("Przedmiot musi być obowiązkowy\nlub obieralny dla wszystkich lub\nprzynajmniej na jednej specjalności");

            if (ns.SubjectTypes == null || ns.SubjectTypes.Count() == 0)
                ns.AddError("Przedmiot musi być przypisany\nprzynajmniej do jednego typu");

            if(ns.Specializations != null)
            foreach(NewSpecializationData nsd in ns.Specializations)
                if (!nsd.IsElective && !nsd.IsGenereal)
                {
                    ns.AddError("Przedmiot na specjalizacji musi być\nobowiązkowy lub obieralny");
                    break;
                }

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

            return this.repository.GetSubjectDataForEditing(subject.Name, departamentId, subject.Ects, 
                facultyId, instituteId, subject.IsExam, subject.PlanId, subject.SemesterId, subject.Specializations);
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
                    subject.AddError("Przedmiot o podanych danych już\nistnieje w planie");

                if (subject.IsElective && subject.IsGeneral)
                    subject.AddError("Przedmiot nie może być\njednocześnie obowiązkowy i obieralny");

                if (!subject.IsElective && !subject.IsGeneral && (subject.Specializations == null || subject.Specializations.Count() == 0))
                    subject.AddError("Przedmiot musi być obowiązkowy\nlub obieralny dla wszystkich lub\nprzynajmniej na jednej specjalności");

                if (subject.SubjectTypes == null || subject.SubjectTypes.Count() == 0)
                    subject.AddError("Przedmiot musi być przypisany\nprzynajmniej do jednego typu");

                if(st != null && st.Ects != subject.Ects && st.SubjectDataID != subject.SubjectId && 
                    st.Subject.Name.ToLower().Equals(subject.Name.ToLower()))
                    subject.AddError("Istnieje przedmiot nadrzędny\n o innej liczbie ECTS");

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
                    
                    if (inst != null)
                        st.InstituteID = inst.InstituteID;
                    else
                        st.InstituteID = null;

                    st.Ects = subject.Ects;
                    st.IsExam = subject.IsExam;
                    st.SemesterID = subject.SemesterId;
                    st.IsElective = subject.IsElective;
                    st.IsGeneral = subject.IsGeneral;

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

                    if (subject.Specializations == null || subject.Specializations.Count() <= 0)
                    {
                        st.SpecializationsData = null;
                    }
                    else 
                    {
                        st.SpecializationsData = new SpecializationsData()
                        {
                            SpecializationID = subject.Specializations.ElementAt(0).SpecializationId,
                            IsElective = subject.Specializations.ElementAt(0).IsElective,
                            IsGeneral = subject.Specializations.ElementAt(0).IsGenereal
                        };
                    }

                    this.repository.EditSubject(st);
                    return true;
                }
            }
            return false;
        }
    }
}
