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
    }
}
