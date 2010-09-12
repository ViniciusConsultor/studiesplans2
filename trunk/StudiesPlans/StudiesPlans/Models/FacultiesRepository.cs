using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlans.Models.Interfaces;

namespace StudiesPlans.Models
{
    public class FacultiesRepository : IFacultiesRepository
    {
        public IEnumerable<Faculty> ListFaculties()
        {
            return (from Faculty f in SPDatabase.DB.Faculties select f);
        }

        public Faculty GetFaculty(string facultyName)
        {
            return (from Faculty f in SPDatabase.DB.Faculties
                    where string.Compare(f.Name, facultyName, true) == 0
                    select f).FirstOrDefault();
        }

        public void AddFaculty(NewFaculty toAdd)
        {
            if (toAdd != null)
            {
                Faculty f = new Faculty()
                {
                    Name = toAdd.FacultyName,
                };
                foreach (Departament d in toAdd.Departaments)
                    f.Departaments.Add(d);
                SPDatabase.DB.Faculties.AddObject(f);
                SPDatabase.DB.SaveChanges();
            }
        }

        public FacultyEdit GetFacultyEdit(string facultyName)
        {
            Faculty f = this.GetFaculty(facultyName);
            f.Departaments.Load();
            if (f != null)
            {
                FacultyEdit ff = new FacultyEdit()
                {
                    FacultyName = f.Name,
                    FacultyID = f.FacultyID,
                    Departaments = f.Departaments
                };
                return ff;
            }
            return null;
        }

        public void DeleteFaculty(Faculty f)
        {
            SPDatabase.DB.Faculties.DeleteObject(f);
            SPDatabase.DB.SaveChanges();
        }

        public void EditFaculty(Faculty toEdit)
        {
            if (toEdit != null)
            {
                SPDatabase.DB.SaveChanges();
            }
        }
    }
}
