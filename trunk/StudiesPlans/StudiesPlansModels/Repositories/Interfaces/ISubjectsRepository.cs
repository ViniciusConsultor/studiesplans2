using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlansModels.Models.Interfaces
{
    public interface ISubjectsRepository
    {
        IEnumerable<SubjectsData> ListSubjects();

        void AddSubject(NewSubject ns);

        SubjectsData GetSubjectData(int subjectDataId);

        SubjectsData GetSubjectData(string subjectName, int departamentId, double ects, int facultyId, int instituteId, bool isExam, int planId, int semesterId);

        void DeleteSubject(SubjectsData sd);

        Subject GetSubject(string subjectName);

        void AddSubjectName(Subject newSubject);

        void EditSubject(SubjectsData st);
    }
}
