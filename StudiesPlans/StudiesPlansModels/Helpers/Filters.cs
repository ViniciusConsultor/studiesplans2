using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlansModels.Helpers
{
    public class PlanFilter
    {
        public string Name { get; set; }
        public string DepartamentName { get; set; }
        public string FacultyName { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsArchieved { get; set; }
        public bool All { get; set; }
        public int YearStart { get; set; }
        public int YearEnd { get; set; }
        public int SemesterStart { get; set; }
        public int SemesterEnd { get; set; }
    }
}
