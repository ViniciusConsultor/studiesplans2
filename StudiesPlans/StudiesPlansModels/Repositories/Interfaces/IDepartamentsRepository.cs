using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlansModels.Models.Interfaces
{
    public interface IDepartamentsRepository
    {
        IEnumerable<Departament> ListDepartaments();

        bool DepartamentExists(string departamentName);
        Departament GetDepartament(string departamentName);

        void AddDepartament(NewDepartament toAdd);

        void DeleteDepartament(Departament d);

        void EditDepartament(DepartamentEdit toEdit);
        Departament GetDepartament(int departamentId);
    }
}
