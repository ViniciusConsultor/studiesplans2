using System.Collections.Generic;

namespace StudiesPlansModels.Models.Interfaces
{
    public interface ISubjectTypesRepository
    {
        IEnumerable<SubjectType> ListSubjectTypes();

        SubjectType GetSubjectType(string name);

        void AddSubjectType(NewSubjectType toAdd);

        SubjectTypeEdit GetSubjectTypeEdit(string subjectTypeName);

        void DeleteSubjectType(SubjectType st);

        SubjectType GetSubjectType(int id);

        void EditSubjectType(SubjectType st);
    }
}
