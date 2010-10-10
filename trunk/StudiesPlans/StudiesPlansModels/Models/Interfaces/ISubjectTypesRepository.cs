using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
