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

        SubjectsData GetSubjectDataForEditing(string subjectName, int departamentId, double ects, int facultyId, int instituteId, bool isExam, int planId, int semesterId, IEnumerable<SpecializationDataEdit> specializations);

        void DeleteSubject(SubjectsData sd);

        Subject GetSubject(string subjectName);

        void AddSubjectName(Subject newSubject);

        void EditSubject(SubjectsData st);

        SubjectsData GetSubjectDataForAdding(string subjectName, int departamentId, double ects, int facultyId, int instituteId, bool isExam, int planId, int semesterId, IEnumerable<NewSpecializationData> specializations);
    }
}
