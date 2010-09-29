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
    }
}
