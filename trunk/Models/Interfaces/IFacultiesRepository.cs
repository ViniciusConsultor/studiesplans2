using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlansModels.Models.Interfaces
{
    public interface IFacultiesRepository
    {
        IEnumerable<Faculty> ListFaculties();

        Faculty GetFaculty(string facultyName);

        void AddFaculty(NewFaculty toAdd);

        FacultyEdit GetFacultyEdit(string facultyName);

        void DeleteFaculty(Faculty f);

        void EditFaculty(Faculty toEdit);
    }
}
