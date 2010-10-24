using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models.Interfaces;

namespace StudiesPlansModels.Models
{
    public class SubjectsRepository : ISubjectsRepository
    {
        public IEnumerable<SubjectsData> ListSubjects()
        {
            return (from SubjectsData sd in SPDatabase.DB.SubjectsDatas select sd);
        }

        public Subject GetSubject(string subjectName)
        {
            return (from Subject s in SPDatabase.DB.Subjects 
                    where string.Compare(subjectName, s.Name, true) == 0 
                    select s).FirstOrDefault();
        }

        public void AddSubject(NewSubject subject)
        {
            Subject s = this.GetSubject(subject.Name);
            if (s == null)
            {
                Subject newSubject = new Subject()
                {
                    Name = subject.Name
                };
                this.AddSubjectName(newSubject);
            }

            s = this.GetSubject(subject.Name);
            
            SubjectsData sd = new SubjectsData()
            {
                DepartamentID = subject.DepartamentId,
                Ects = subject.Ects,
                FacultyID = subject.FacultyId,
                InstituteID = subject.InstituteId,
                IsExam = subject.IsExam,
                SemesterID = subject.SemesterId,
                SpecializationDataID = null,
                SubjectID = s.SubjectID
            };

            Plan p = GetPlan(subject.PlanId);
            if (p != null)
                sd.Plans.Add(p);

            foreach (NewSubjectTypeData d in subject.SubjectTypes)
            {
                SubjectTypesData std = new SubjectTypesData()
                {
                    Hours = d.Hours,
                    SubjectTypeID = d.SubjectTypeId
                };

                sd.SubjectTypesDatas.Add(std);
            }

            SPDatabase.DB.SubjectsDatas.AddObject(sd);
            SPDatabase.DB.SaveChanges();
        }

        private Plan GetPlan(int planId)
        {
            return (from Plan p in SPDatabase.DB.Plans
                    where p.PlanID == planId
                    select p).FirstOrDefault();
        }

        public void AddSubjectName(Subject newSubject)
        {
            if (newSubject != null)
            {
                SPDatabase.DB.Subjects.AddObject(newSubject);
                SPDatabase.DB.SaveChanges();
            }
        }

        public SubjectsData GetSubjectData(int subjectDataId)
        {
            return (from SubjectsData sd in SPDatabase.DB.SubjectsDatas
                    where sd.SubjectDataID == subjectDataId
                    select sd).FirstOrDefault();
        }

        public SubjectsData GetSubjectData(string subjectName, int departamentId, double ects, int facultyId, int instituteId, bool isExam, int planId, int semesterId)
        {
            SubjectsData s = (from SubjectsData sd in SPDatabase.DB.SubjectsDatas
                              where sd.DepartamentID == departamentId &&
                              sd.Ects == ects &&
                              sd.FacultyID == facultyId &&
                              sd.InstituteID == instituteId &&
                              sd.IsExam == isExam &&
                              sd.SemesterID == semesterId &&
                              string.Compare(sd.Subject.Name, subjectName, true) == 0
                              select sd).FirstOrDefault();

            if(s!=null)
                foreach (Plan p in s.Plans)
                {
                    if (p.PlanID == planId)
                        return s;
                }

            return null;
        }
    }
}
