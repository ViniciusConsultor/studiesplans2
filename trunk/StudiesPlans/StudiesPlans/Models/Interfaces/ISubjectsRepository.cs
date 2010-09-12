using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlans.Models.Interfaces
{
    public interface ISubjectsRepository
    {
        IEnumerable<SubjectsData> ListSubjects();
    }
}
