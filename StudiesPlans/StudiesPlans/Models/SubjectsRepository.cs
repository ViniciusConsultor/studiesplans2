using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlans.Models.Interfaces;

namespace StudiesPlans.Models
{
    public class SubjectsRepository : ISubjectsRepository
    {
        public IEnumerable<SubjectsData> ListSubjects()
        {
            return (from SubjectsData sd in SPDatabase.DB.SubjectsDatas select sd);
        }
    }
}
