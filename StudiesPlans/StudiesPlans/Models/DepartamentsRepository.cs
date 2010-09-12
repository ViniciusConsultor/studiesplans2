using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlans.Models.Interfaces;

namespace StudiesPlans.Models
{
    public class DepartamentsRepository : IDepartamentsRepository
    {
        public IEnumerable<Departament> ListDepartaments()
        {
            return (from Departament d in SPDatabase.DB.Departaments select d);
        }

        public bool DepartamentExists(string departamentName)
        {
            Departament d = this.GetDepartament(departamentName);
            if (d != null)
                return true;
            return false;
        }

        public Departament GetDepartament(string departamentName)
        {
            return (from Departament d in SPDatabase.DB.Departaments
                    where string.Compare(departamentName, d.Name, true) == 0
                    select d).FirstOrDefault();
        }

        public void AddDepartament(NewDepartament departament)
        { 
            if (departament != null)
            {
                Departament d = new Departament()
                {
                    Name = departament.DepartamentName
                };
                SPDatabase.DB.Departaments.AddObject(d);
                SPDatabase.DB.SaveChanges();
            }
        }

        public void DeleteDepartament(Departament d)
        {
            if (d != null)
            {
                SPDatabase.DB.Departaments.DeleteObject(d);
                SPDatabase.DB.SaveChanges();
            }
        }

        public void EditDepartament(DepartamentEdit d)
        {
            if (d != null)
            {
                Departament dd = this.GetDepartament(d.DepartamentID);
                if (dd != null)
                {
                    dd.Name = d.DepartamentName;
                    SPDatabase.DB.SaveChanges();
                }
            }
        }

        public Departament GetDepartament(int departamentId)
        {
            return (from Departament d in SPDatabase.DB.Departaments
                    where d.DepartamentID == departamentId
                    select d).FirstOrDefault();
        }
    }
}
