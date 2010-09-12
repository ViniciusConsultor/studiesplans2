using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlans.Models.Interfaces;
using StudiesPlans.Models;
using System.Data;

namespace StudiesPlans.Controllers
{
    public class FacultyController
    {
        private static FacultyController instance;
        private IFacultiesRepository repository;

        public static FacultyController Instance
        {
            get
            {
                if (instance == null)
                    instance = new FacultyController(new FacultiesRepository());

                return instance;
            }
        }

        public FacultyController(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Faculty> ListFaculties()
        {
            return this.repository.ListFaculties();
        }

        public bool AddFaculty(NewFaculty toAdd)
        {
            Faculty f = this.repository.GetFaculty(toAdd.FacultyName);
            if (f != null)
                toAdd.AddError("Kierunek o takiej nazwie już istnieje");
            if (toAdd.IsValid)
            {
                this.repository.AddFaculty(toAdd);
                return true;
            }
            return false;
        }

        public FacultyEdit GetFacultyEdit(string facultyName)
        {
            return this.repository.GetFacultyEdit(facultyName);
        }

        public void DeleteFaculty(FacultyEdit toEdit)
        {
            Faculty f = this.repository.GetFaculty(toEdit.FacultyName);
            if (f != null && (f.Plans.Count > 0 || f.SubjectsDatas.Count > 0))
                throw new UpdateException("Nie można usunąć kierunku,\nponieważ posiada powiązania");
            else
            {
                this.repository.DeleteFaculty(f);
            }
        }

        public bool EditFaculty(FacultyEdit toEdit)
        {
            if (toEdit != null)
            {
                Faculty f = this.repository.GetFaculty(toEdit.FacultyName);
                if (f != null && f.FacultyID != toEdit.FacultyID && f.Name.Equals(toEdit.FacultyName))
                    toEdit.AddError("Kierunek o takiej nazwie już istnieje");

                if (toEdit.IsValid)
                {
                    f.Name = toEdit.FacultyName;
                    f.Departaments.Clear();
                    foreach (Departament d in toEdit.Departaments)
                        f.Departaments.Add(d);

                    this.repository.EditFaculty(f);
                    return true;
                }
            }
            return false;
        }
    }
}
