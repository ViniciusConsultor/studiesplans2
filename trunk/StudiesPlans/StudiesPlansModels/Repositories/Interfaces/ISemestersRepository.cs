using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlansModels.Models.Interfaces
{
    public interface ISemestersRepository
    {
        IEnumerable<Semester> ListSemesters();

        Semester GetSemester(string semesterName, int semesterNo, int semesterYear);

        void AddSemester(NewSemester toAdd);

        void DeleteSpecialization(Semester s);

        Semester GetSemester(int semesterId);

        void EditSemester(Semester s);

        Semester GetSemester(string semesterName);
    }
}
