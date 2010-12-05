using System.Collections.Generic;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;
using System.Data;

namespace StudiesPlans.Controllers
{
    public class FacultyController
    {
        private static FacultyController _instance;
        private readonly IFacultiesRepository _repository;

        public static FacultyController Instance
        {
            get { return _instance ?? (_instance = new FacultyController(new FacultiesRepository())); }
        }

        public FacultyController(IFacultiesRepository repository)
        {
            this._repository = repository;
        }

        public IEnumerable<Faculty> ListFaculties()
        {
            return this._repository.ListFaculties();
        }

        public bool AddFaculty(NewFaculty toAdd)
        {
            Faculty f = this._repository.GetFaculty(toAdd.FacultyName);
            if (f != null)
                toAdd.AddError("Kierunek o takiej nazwie już istnieje");
            if (toAdd.IsValid)
            {
                this._repository.AddFaculty(toAdd);
                return true;
            }
            return false;
        }

        public FacultyEdit GetFacultyEdit(string facultyName)
        {
            return this._repository.GetFacultyEdit(facultyName);
        }

        public Faculty GetFaculty(string facultyName)
        {
            return this._repository.GetFaculty(facultyName);
        }

        public void DeleteFaculty(FacultyEdit toEdit)
        {
            Faculty f = this._repository.GetFaculty(toEdit.FacultyName);
            if (f != null && (f.Plans.Count > 0 || f.SubjectsDatas.Count > 0 || f.Specializations.Count > 0))
                throw new UpdateException("Nie można usunąć kierunku,\nponieważ posiada powiązania");
            else
            {
                this._repository.DeleteFaculty(f);
            }
        }

        public bool EditFaculty(FacultyEdit toEdit)
        {
            if (toEdit != null)
            {
                Faculty f = this._repository.GetFaculty(toEdit.FacultyName);
                if (f != null && f.FacultyID != toEdit.FacultyID && f.Name.Equals(toEdit.FacultyName))
                    toEdit.AddError("Kierunek o takiej nazwie już istnieje");

                if (toEdit.IsValid)
                {
                    f = this._repository.GetFaculty(toEdit.FacultyID);
                    f.Name = toEdit.FacultyName;
                    f.Departaments.Clear();
                    foreach (Departament d in toEdit.Departaments)
                        f.Departaments.Add(d);

                    this._repository.EditFaculty(f);
                    return true;
                }
            }
            return false;
        }

        public List<Faculty> ListFaculties(int departamentId)
        {
            return this._repository.ListFaculties(departamentId);
        }

        public Faculty GetFaculty(int facultyId)
        {
            return this._repository.GetFaculty(facultyId);
        }
    }
}
