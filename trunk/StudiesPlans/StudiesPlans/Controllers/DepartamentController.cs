using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlans.Models.Interfaces;
using StudiesPlans.Models;
using System.Data;

namespace StudiesPlans.Controllers
{
    public class DepartamentController
    {
        private static DepartamentController instance;
        private IDepartamentsRepository repository;

        public static DepartamentController Instance
        {
            get
            {
                if (instance == null)
                    instance = new DepartamentController(new DepartamentsRepository());

                return instance;
            }
        }

        public DepartamentController(IDepartamentsRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Departament> ListDepartaments()
        {
            return this.repository.ListDepartaments();
        }

        public bool AddDepartament(NewDepartament toAdd)
        {
            if (toAdd != null)
            {
                if (this.repository.DepartamentExists(toAdd.DepartamentName))
                    toAdd.AddError("Wydział o podanej nazwie już istnieje");
                if (toAdd.IsValid)
                {
                    this.repository.AddDepartament(toAdd);
                    return true;
                }
            }
            return false;
        }

        public Departament GetDepartament(string departamentName)
        {
            Departament d = this.repository.GetDepartament(departamentName);
            return d;
        }

        public DepartamentEdit GetDepartamentEdit(string departamentName)
        {
            Departament d = this.repository.GetDepartament(departamentName);
            if (d != null)
            {
                return new DepartamentEdit()
                {
                    DepartamentID = d.DepartamentID,
                    DepartamentName = d.Name
                };
            }
            return null;
        }

        public void DeleteDepartament(DepartamentEdit toEdit)
        {
            Departament d = this.repository.GetDepartament(toEdit.DepartamentName);
            if (d != null && (d.Faculties.Count > 0 || d.Institutes.Count > 0 || d.Plans.Count > 0 || d.SubjectsDatas.Count > 0))
                throw new UpdateException("Nie można usunąć wydziału,\nponieważ posiada powiązania");
            else
            {
                this.repository.DeleteDepartament(d);
            }
        }

        public bool EditDepartament(DepartamentEdit toEdit)
        {
            if (toEdit != null)
            {
                if (toEdit.Errors != null)
                    toEdit.Errors.Clear();
                Departament d = this.repository.GetDepartament(toEdit.DepartamentName);
                if (d != null && d.DepartamentID != toEdit.DepartamentID)
                    toEdit.AddError("Wydział o podanej nazwie już istnieje");
                if (toEdit.IsValid)
                {
                    this.repository.EditDepartament(toEdit);
                    return true;
                }
            }
            return false;
        }
    }
}
