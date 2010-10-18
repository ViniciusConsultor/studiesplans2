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

        public void AddSubjectName(Subject newSubject)
        {
            if (newSubject != null)
            {
                SPDatabase.DB.Subjects.AddObject(newSubject);
                SPDatabase.DB.SaveChanges();
            }
        }
    }
}
